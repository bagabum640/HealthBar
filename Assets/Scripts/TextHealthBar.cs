using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextHealthBar : HealthBar
{
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    public override void UpdateHealhtAmount()
    {
        _text.text = $"{Health.CurrentAmount} / {Health.MaxAmount}";
    }
}