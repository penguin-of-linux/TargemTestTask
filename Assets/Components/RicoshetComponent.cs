using UnityEngine;

public class RicoshetComponent : MonoBehaviour
{
    public const float RicoshetForce = 10000f;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        var otherRigidBody = other.rigidbody;
        var otherRicoshetComponent = otherRigidBody.GetComponent<RicoshetComponent>();
        if (otherRicoshetComponent != null)
        {
            var otherDirection = otherRigidBody.velocity;
            rigidBody.AddForce(RicoshetForce * otherDirection.normalized);
            Debug.Log("huj");
        }
    }

    private Rigidbody rigidBody;
}
