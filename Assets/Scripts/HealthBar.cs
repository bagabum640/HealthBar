using UnityEngine;

public abstract class HealthBar: MonoBehaviour 
{
    [SerializeField] protected Health _health;

    private void OnEnable()
    {
        _health.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= OnHealthChanged;
    }

    public abstract void OnHealthChanged();
}