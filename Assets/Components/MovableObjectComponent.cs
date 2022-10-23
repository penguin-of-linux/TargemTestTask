using UnityEngine;

namespace Assets.Components
{
    public class MovableObjectComponent : MonoBehaviour
    {
        public Rigidbody RigidBody;
        public bool GravityEnabled;

        void Start()
        {
            gravityPoints = FindObjectsOfType<GravityPointComponent>();
            RigidBody = GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            if (!GravityEnabled) 
                return;

            var commonForce = new Vector3(0, 0, 0);
            foreach (var gravityPoint in gravityPoints)
            {
                var distance = gravityPoint.gameObject.transform.position - transform.position;
                var r = distance.magnitude;
                var force = Rules.GravitationalConstant * RigidBody.mass * gravityPoint.Mass / r / r;
                commonForce += distance.normalized * force;
            }

            var acceleration = commonForce / RigidBody.mass;
            if (acceleration.magnitude > Rules.MaximumGravityObjectAcceleration)
            {
                acceleration = acceleration.normalized * Rules.MaximumGravityObjectAcceleration;
            }
            if (acceleration.magnitude < Rules.MinimumGravityObjectAcceleration)
            {
                acceleration = acceleration.normalized * Rules.MinimumGravityObjectAcceleration;
            }

            RigidBody.AddForce(acceleration, ForceMode.Acceleration);
        }

        private GravityPointComponent[] gravityPoints;
    }
}
