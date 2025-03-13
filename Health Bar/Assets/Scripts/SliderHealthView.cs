using UnityEngine;
using UnityEngine.UI;

public class SliderHealthView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;

    private void OnEnable()
    {
        _health.ValueChanged += ChangeValue;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= ChangeValue;
    }

    private void Start()
    {
        _slider.maxValue = _health.MaxValue;
        _slider.value = _health.MaxValue;
    }

    private void ChangeValue(float value)
    {
        _slider.value = value;
    }
}