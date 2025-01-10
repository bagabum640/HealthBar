using UnityEngine.UI;

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