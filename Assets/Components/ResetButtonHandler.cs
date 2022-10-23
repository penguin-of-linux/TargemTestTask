using UnityEngine;
using UnityEngine.UI;

public class ResetButtonHandler : MonoBehaviour
{
    void Start()
    {
        timer = FindObjectOfType<TimerComponent>();
        collisionCountComponents = FindObjectsOfType<CollisionCountComponent>();
        var btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        timer.Reset();
        foreach(var component in collisionCountComponents)
        {
            component.Value = 0;
        }
    }

    private TimerComponent timer;
    private CollisionCountComponent[] collisionCountComponents;
}
