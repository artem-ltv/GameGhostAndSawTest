using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public event UnityAction Dying;

    [SerializeField] private int _health;
    [SerializeField] private ParticleSystem _deathEffect;

    public void ApplyDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
            Die();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            player.ApplyDamage(1);
            Destroy(gameObject);
        }
    }

    private void Die()
    {
        Instantiate(_deathEffect, transform.position, Quaternion.identity);
        Dying?.Invoke();
        Destroy(gameObject);
    } 
}
