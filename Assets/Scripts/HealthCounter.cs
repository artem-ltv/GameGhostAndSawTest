using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    [SerializeField] private Text _playerHealthUI;
    [SerializeField] private Player _player;

    private void Start()
    {
        _playerHealthUI.text = _player.Health.ToString();
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
        if (_player.Health <= 0)
            _player.Health = 0;
        _playerHealthUI.text = _player.Health.ToString();
    }

}
