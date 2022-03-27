using UnityEngine;
using UnityEngine.UI;

public class KeyCounterUI : MonoBehaviour
{
    [SerializeField] private Text _countKey;
    [SerializeField] private Key[] _keys;

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

    private void ChangeCountKeyUI(int counterKeys)
    {
        _countKey.text = $"{counterKeys}/5";
    }
}
