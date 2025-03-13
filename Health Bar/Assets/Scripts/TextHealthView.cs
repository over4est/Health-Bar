using TMPro;
using UnityEngine;

public class TextHealthView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Health _health;

    private string _separator = "/";
    private float _maxValue;

    private void OnEnable()
    {
        _health.ValueChanged += ChangeText;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= ChangeText;
    }

    private void Start()
    {
        _maxValue = _health.MaxValue;
        _text.text = _maxValue + _separator + _maxValue;
    }

    private void ChangeText(float currentValue)
    {
        _text.text = currentValue.ToString() + _separator + _maxValue;
    }
}