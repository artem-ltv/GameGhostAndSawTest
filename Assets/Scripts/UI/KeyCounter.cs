using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(EndGame))]
public class KeyCounter : MonoBehaviour
{
    public int CounterKey => _counterKeys;

    [SerializeField] private Text _countKeyUI;

    private Key[] _keys;
    private EndGame _endGame;
    private AudioSource _takingKeySound;
    private int _counterKeys = 0;

    private void Awake() =>
        _keys = GameObject.FindObjectsOfType<Key>();
    

    private void Start()
    {
        _takingKeySound = GetComponent<AudioSource>();
        _endGame = GetComponent<EndGame>();
    }

    private void OnEnable()
    {
        foreach (var key in _keys)
        {
            key.TakingKey += ChangeCountKeyUI;
            key.TakingKey += PlaySoundKey;
        }
    }

    private void OnDisable()
    {
        foreach(var key in _keys)
        {
            key.TakingKey -= ChangeCountKeyUI;
            key.TakingKey += PlaySoundKey;
        }
    }

    private void ChangeCountKeyUI()
    {
        _counterKeys++;
        _countKeyUI.text = $"{_counterKeys}/5";
        _endGame.ChekingCountKey(_counterKeys);
    }

    private void PlaySoundKey() =>
        _takingKeySound.Play();
}
