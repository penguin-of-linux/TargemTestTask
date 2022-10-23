using UnityEngine;

namespace Assets.Components
{
    public class SlowdownComponent : MonoBehaviour
    {
        public float Drag;

        void OnTriggerEnter(Collider other)
        {
            Debug.Log("huj");
            var movableComponent = other.gameObject.GetComponent<MovableObjectComponent>();
            if (movableComponent != null)
            {
                originalDrag = movableComponent.RigidBody.drag;
                movableComponent.RigidBody.drag = Drag;
                movableComponent.GravityEnabled = false;
            }
        }

        void OnTriggerExit(Collider other)
        {
            var movableComponent = other.gameObject.GetComponent<MovableObjectComponent>();
            if (movableComponent != null)
            {
                movableComponent.GravityEnabled = true;
                movableComponent.RigidBody.drag = originalDrag;
            }
        }

        private float originalDrag;
    }
}
