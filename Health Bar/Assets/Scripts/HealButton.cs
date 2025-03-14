using UnityEngine;

public class HealButton : HealthButton
{
    [SerializeField] private float _healValue;

    protected override void ActionOnClick()
    {
        Health.Heal(_healValue);
    }
}