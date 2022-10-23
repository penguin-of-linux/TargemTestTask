using UnityEngine;
using UnityEngine.UI;

public class TimerComponent : MonoBehaviour
{
    public float Value;

    void Start()
    {
        Value = 0;
        startValue = 0;
        textComponent = GetComponent<Text>();
    }

    void Update()
    {
        if (Time.time - startValue - Value >= 1)
            Value++;
        textComponent.text = $"Времени прошло: {Value}";
    }

    public void Reset()
    {
        startValue = Time.time;
        Value = 0;
        Update();
    }

    private Text textComponent;
    private float startValue;
}
