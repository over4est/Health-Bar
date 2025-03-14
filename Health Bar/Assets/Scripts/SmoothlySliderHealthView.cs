using System.Collections;
using UnityEngine;

public class SmoothlySliderHealthView : SliderHealthView
{
    [SerializeField] private float _changeDuration;

    private Coroutine _corutine;

    protected override void ChangeValue(float value)
    {
        if (_corutine != null)
            StopCoroutine(_corutine);

        _corutine = StartCoroutine(SmoothlyChange(value));
    }

    private IEnumerator SmoothlyChange(float value)
    {
        float startValue = Slider.value;
        float targetValue = value / MaxValue;
        float timeElapsed = 0f;

        while (timeElapsed < _changeDuration)
        {
            float delta = timeElapsed / _changeDuration;

            Slider.value = Mathf.Lerp(startValue, targetValue, delta);
            timeElapsed += Time.deltaTime;

            yield return null;
        }
    }
}