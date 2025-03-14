using UnityEngine;
using UnityEngine.UI;

public class SliderHealthView : HealthView
{
    [SerializeField] protected Slider Slider;

    private void Start()
    {
        Slider.value = CurrentValue / MaxValue;
    }

    protected override void ChangeValue(float value)
    {
        Slider.value = value / MaxValue;
    }
}