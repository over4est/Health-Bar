using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class HealthButton : MonoBehaviour
{
    [SerializeField] private Health _health;

    private Button _button;

    protected Health Health => _health;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(ActionOnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ActionOnClick);
    }

    protected abstract void ActionOnClick();
}
