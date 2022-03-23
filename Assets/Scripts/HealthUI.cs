using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private Text _playerHealth;
    [SerializeField] private Player _player;

    private void Start()
    {
        _playerHealth.text = _player.Health.ToString();
    }

    private void OnEnable()
    {
        _player.ChangeCountHealth += ChangeCountHealthUI;
    }

    private void OnDisable()
    {
        _player.ChangeCountHealth -= ChangeCountHealthUI;
    }
    
    private void ChangeCountHealthUI()
    {
        _playerHealth.text = _player.Health.ToString();
    }

}
