using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private const int MinAmount = 0;

    public int MaxAmount { get; private set; } = 100;
    public int CurrentAmount { get; private set; }
    public bool IsAlive => CurrentAmount > 0;

    public event Action ValueChanged;
    public event Action Died;

    private void Awake()
    {
        CurrentAmount = MaxAmount;      
    }

    private void Start()
    {
        ValueChanged?.Invoke();
    }

    public void TakeDamage(int damage)
    {
        if (damage >= 0)
            CurrentAmount = Mathf.Clamp(CurrentAmount - damage, MinAmount, MaxAmount);

        if (CurrentAmount <= 0)
            Died?.Invoke();

        ValueChanged?.Invoke();
    }

    public void Restore(int healthAmount)
    {
        CurrentAmount = Mathf.Clamp(CurrentAmount + Mathf.Abs(healthAmount), MinAmount, MaxAmount);

        ValueChanged?.Invoke();
    }

    public bool GetPossibleOfHealing() =>
        CurrentAmount < MaxAmount;
}