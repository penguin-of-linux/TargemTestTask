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
        // ����� �� 2, �.�. ������� ������ ��� ���� ��������.
        // ��� ������� - �������� ������� �� 1 ������, �� ��� ������������� �������
        textComponent.text = $"������������: {sum / 2}";
    }

    private CollisionCountComponent[] components;
    private Text textComponent;
}
