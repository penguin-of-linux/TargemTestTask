using UnityEngine;

public class CollisionCountComponent : MonoBehaviour
{
    public int Value;

    void Start()
    {
        Value = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        Value++;
    }
}
