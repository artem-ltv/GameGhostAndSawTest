using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    private bool isPause = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;

            if (isPause)
                ShowPauseMenu(isPause, 0f);
            else
                ShowPauseMenu(isPause, 1f);
        }
    }

    private void ShowPauseMenu(bool isActive, float timeScale)
    {
        _pausePanel.SetActive(isActive);
        Time.timeScale = timeScale;
    }

    public void Continue()
    {
        ShowPauseMenu(false, 1f);
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(1);
    }
}
