using UnityEngine;

public class ColorChangeComponent : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        var meshRenderer = GetComponent<MeshRenderer>();
        var myParentId = transform.parent.gameObject.GetInstanceID();
        var otherParentId = other.transform.parent.gameObject.GetInstanceID();
        if (meshRenderer != null && myParentId != otherParentId)
        {
            meshRenderer.material.color = Color.red;
        }
    }
}
