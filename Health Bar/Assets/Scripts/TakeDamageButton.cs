using UnityEngine;

public class TakeDamageButton : HealthButton
{
    [SerializeField] private float _damage;

    protected override void ActionOnClick()
    {
        Health.TakeDamage(_damage);
    }
}