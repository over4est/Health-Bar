using TMPro;
using UnityEngine;

public class TextHealthView : HealthView
{
    [SerializeField] private TextMeshProUGUI _text;

    private string _separator = "/";

    private void Start()
    {
        _text.text = CurrentValue + _separator + MaxValue;
    }

    protected override void ChangeValue(float value)
    {
        _text.text = value + _separator + MaxValue;
    }
}