using UnityEngine;
using UnityEngine.UI;

public class TimerComponent : MonoBehaviour
{
    public float Value;

    void Start()
    {
        Value = Time.time;
        textComponent = GetComponent<Text>();
    }

    void Update()
    {
        if (Time.time - Value >= 1)
            textComponent.text = $"Времени прошло: {(int)(Value = Time.time)}";
    }

    private Text textComponent;
}
