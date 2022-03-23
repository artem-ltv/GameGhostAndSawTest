using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private Button _restart;
    [SerializeField] private Button _exit;

    private void OnEnable()
    {
        _player.PlayerDie += SetLosePanel;
    }

    private void OnDisable()
    {
        _player.PlayerDie -= SetLosePanel;        
    }

    private void SetLosePanel()
    {
        _losePanel.SetActive(true);
    }

    public void RestartLevel() {
        SceneManager.LoadScene(0);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
