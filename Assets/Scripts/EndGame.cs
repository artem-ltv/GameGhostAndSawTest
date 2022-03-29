using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject _winnerPanel;

    public void ChekingCountKey(int count)
    {
        if (count == 5)
            Win();
    }

    private void Win()
    {
        _winnerPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
