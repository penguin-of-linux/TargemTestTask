using UnityEngine;

public class ColorChangeComponent : MonoBehaviour
{
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        HandleCollision();
    }

    void OnCollisionEnter(Collision other)
    {
        HandleCollision();
    }

    private void HandleCollision()
    {
        meshRenderer.material.color = Color.red;        
    }

    private MeshRenderer meshRenderer;
}
