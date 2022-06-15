using System.Collections;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject _winnerPanel;

    public void ChekingCountKey(int count)
    {
        if (count == 5)
             StartCoroutine(Win());
    }

    private IEnumerator Win()
    {
        _winnerPanel.SetActive(true);
        yield return new WaitForSeconds(1);
        Time.timeScale = 0f;
    }
}
