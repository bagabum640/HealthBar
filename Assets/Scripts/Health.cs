using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private const int MinAmount = 0;

    [SerializeField] private int _maxAmount = 100;

    private int _currentAmount;

    public int MaxAmount => _maxAmount;
    public float CurrentAmount => _currentAmount;
    public bool IsAlive => _currentAmount > 0;

    public event Action UpdateAmount;
    public event Action Died;

    private void Awake()
    {
        _currentAmount = _maxAmount;      
    }

    private void Start()
    {
        UpdateAmount?.Invoke();
    }

    public void TakeDamage(int damage)
    {
        if (damage >= 0)
            _currentAmount = Mathf.Clamp(_currentAmount - damage, MinAmount, _maxAmount);

        if (_currentAmount <= 0)
            Died?.Invoke();

        UpdateAmount?.Invoke();
    }

    public void Restore(int healthAmount)
    {
       _currentAmount = Mathf.Clamp(_currentAmount + Mathf.Abs(healthAmount), MinAmount, _maxAmount);

        UpdateAmount?.Invoke();
    }

    public bool GetPossibleOfHealing() =>
        _currentAmount < _maxAmount;
}