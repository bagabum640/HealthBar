using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealButton : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private int _amount = 15;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(RestoreHealth);
    }

    public void RestoreHealth()
    {
        _health.Restore(_amount);
    }
}