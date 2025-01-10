using UnityEngine;

public abstract class HealthBar: MonoBehaviour 
{
    [SerializeField] protected Health Health;

    private void OnEnable()
    {
        Health.UpdateAmount += UpdateHealhtAmount;
    }

    private void OnDisable()
    {
        Health.UpdateAmount -= UpdateHealhtAmount;
    }

    public abstract void UpdateHealhtAmount();
}