using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] private Health _health;

    protected float MaxValue;
    protected float CurrentValue;

    private void Awake()
    {
        MaxValue = _health.MaxValue;
        CurrentValue = MaxValue;
    }

    private void OnEnable()
    {
        _health.ValueChanged += ChangeValue;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= ChangeValue;
    }

    protected abstract void ChangeValue(float value);
}