using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSliderBar : HealthBar
{
    [SerializeField] protected Text _text;
    protected Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>(); 
        _slider.maxValue = _health.MaxAmount;
    }

    public override void OnHealthChanged()
    {
        _slider.value = _health.CurrentAmount;
        _text.text = $"{_health.CurrentAmount} / {_health.MaxAmount}";
    }
}