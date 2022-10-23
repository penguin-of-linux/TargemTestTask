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
        var otherRicoshetComponent = other.gameObject.GetComponent<RicoshetComponent>();
        if (otherRicoshetComponent != null)
        {
            var direction = transform.position - other.gameObject.transform.position;
            rigidBody.AddForce(RicoshetForce * direction.normalized);
        }
    }

    private Rigidbody rigidBody;
}
