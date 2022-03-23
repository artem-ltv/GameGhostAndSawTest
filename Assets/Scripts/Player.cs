using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(PlayerController))]

public class Player : MonoBehaviour
{
    public int Health;
    public event UnityAction ChangeCountHealth;
    public event UnityAction PlayerDie;

    private SpriteRenderer _spriteRenderer;
    private PlayerController _playerController;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _playerController = GetComponent<PlayerController>();
    }

    public void ApplyDamage(int damage)
    {
        Health -= damage;
        ChangeCountHealth?.Invoke();
        _spriteRenderer.DOColor(Color.red, 0.5f).From();

        if (Health <= 0)
            Die();
    }

    private void Die()
    {
        PlayerDie?.Invoke();
        _playerController.enabled = false;
    }
}
