using System.Collections;
using UnityEngine;

public class SmoothHealthSliderBar : HealthSliderBar
{
    [SerializeField] private float _fillingSpeed = 10f;

    private Coroutine _coroutine;

    public override void OnHealthChanged()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(SmoothFill());        
    }

    private IEnumerator SmoothFill()
    {
        while (_slider.value != _health.CurrentAmount)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health.CurrentAmount, _fillingSpeed * Time.deltaTime);
            _text.text = $"{Mathf.MoveTowards(_slider.value, _health.CurrentAmount, _fillingSpeed * Time.deltaTime):0} / {_health.MaxAmount}";

            yield return null;
        }
    }
}