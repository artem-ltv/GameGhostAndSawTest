using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _losePanel;

    private void OnEnable()
    {
        _player.PlayerDie += ShowLosePanel;
    }

    private void OnDisable()
    {
        _player.PlayerDie -= ShowLosePanel;        
    }

    private void ShowLosePanel()
    {
        _losePanel.SetActive(true);
    }

    public void RestartLevel() {
        SceneManager.LoadScene(1);
    }
    
    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
