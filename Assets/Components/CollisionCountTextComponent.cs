using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CollisionCountTextComponent : MonoBehaviour
{
    void Start()
    {
        components = FindObjectsOfType<CollisionCountComponent>();
        textComponent = GetComponent<Text>();
    }

    void Update()
    {
        var sum = components.Sum(x => x.Value);
        // Делим на 2, т.к. счетчик капает для всех объектов.
        // Как вариант - навесить счетчик на 1 объект, но это нерасширяемое решение
        textComponent.text = $"Столкновений: {sum / 2}";
    }

    private CollisionCountComponent[] components;
    private Text textComponent;
}
