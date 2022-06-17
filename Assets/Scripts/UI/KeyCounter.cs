using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(EndGame))]
public class KeyCounter : MonoBehaviour
{
    [SerializeField] private Text _countKeyUI;
    [SerializeField] private Key[] _keys;

    public int CounterKey => _counterKeys;
    private int _counterKeys = 0;

    private EndGame _endGame;

    private void Start()
    {
        _endGame = GetComponent<EndGame>();
    }

    private void OnEnable()
    {
        foreach (var key in _keys)
            key.TakingKey += ChangeCountKeyUI;
    }

    private void OnDisable()
    {
        foreach(var key in _keys)
            key.TakingKey -= ChangeCountKeyUI;
    }

    private void ChangeCountKeyUI()
    {
        _counterKeys++;
        _countKeyUI.text = $"{_counterKeys}/5";
        _endGame.ChekingCountKey(_counterKeys);
    }
}
