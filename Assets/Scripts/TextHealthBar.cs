using UnityEngine.UI;

public class TextHealthBar : HealthBar
{
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    public override void OnHealthChanged()
    {
        _text.text = $"{_health.CurrentAmount} / {_health.MaxAmount}";
    }
}