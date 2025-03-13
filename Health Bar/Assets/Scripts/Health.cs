using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxValue;

    private float _currentValue;

    public event Action<float> ValueChanged;

    public float MaxValue => _maxValue;

    private void Start()
    {
        _currentValue = _maxValue;
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            return;
        }

        if (_currentValue - damage < 0)
        {
            _currentValue = 0;
        }
        else
        {
            _currentValue -= damage;
        }

        ValueChanged?.Invoke(_currentValue);
    }

    public void Heal(float value)
    {
        if (value < 0)
        {
            return;
        }

        if (value + _currentValue > _maxValue)
        {
            _currentValue = _maxValue;
        }
        else
        {
            _currentValue += value;
        }

        ValueChanged?.Invoke(_currentValue);
    }
}