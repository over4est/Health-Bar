using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothlySliderHealthView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;
    [SerializeField] private float _changeDelay;
    [SerializeField] private float _delta;

    private Coroutine _corutine;
    private WaitForSeconds _wait;

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
        _wait = new WaitForSeconds(_changeDelay);
        _slider.maxValue = _health.MaxValue;
        _slider.value = _slider.maxValue;
    }

    private void ChangeValue(float value)
    {
        if (_corutine != null)
        {
            StopCoroutine(_corutine);
        }

        _corutine = StartCoroutine(SmoothlyChange(value));
    }

    private IEnumerator SmoothlyChange(float value)
    {
        while (enabled)
        {
            yield return _wait;

            _slider.value = Mathf.MoveTowards(_slider.value, value, _delta);
        }
    }
}
