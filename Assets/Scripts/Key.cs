using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class Key : MonoBehaviour
{
    public event UnityAction TakingKey;

    [SerializeField] private Color _keyColor;
    [SerializeField] private ParticleSystem _takingKeyEffect;

    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(_keyColor, 1f).SetLoops(-1, LoopType.Yoyo);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            Instantiate(_takingKeyEffect, transform.position, Quaternion.identity);
            TakingKey?.Invoke();
            gameObject.SetActive(false);
        }
    }
}
