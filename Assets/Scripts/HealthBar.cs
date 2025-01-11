using UnityEngine;

public abstract class HealthBar: MonoBehaviour 
{
    [SerializeField] protected Health Health;

    private void OnEnable()
    {
        Health.ValueChanged += UpdateHealhtAmount;
    }

    private void OnDisable()
    {
        Health.ValueChanged -= UpdateHealhtAmount;
    }

    public abstract void UpdateHealhtAmount();
}