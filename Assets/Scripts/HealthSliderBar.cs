using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSliderBar : HealthBar
{
    protected Slider Slider;

    private void Awake()
    {
        Slider = GetComponent<Slider>(); 

        Slider.maxValue = Health.MaxAmount;
    }

    public override void UpdateHealhtAmount()
    {
        Slider.value = Health.CurrentAmount;
    }
}