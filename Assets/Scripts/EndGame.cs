using UnityEngine;
using DG.Tweening;

public class EndGame : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer.DOFade(1f, 2f);
    }
}
