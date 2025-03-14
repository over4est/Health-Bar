using UnityEngine;
using UnityEngine.UI;

public class SliderHealthView : HealthView
{
    [SerializeField] private Slider _slider;

    protected Slider Slider => _slider;

    private void Start()
    {
        _slider.value = MaxValue / MaxValue;
    }

    protected override void ChangeValue(float value)
    {
        _slider.value = value / MaxValue;
    }
}