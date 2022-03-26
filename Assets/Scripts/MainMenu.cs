using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void Play()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
