using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;

    public void ApplyDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            player.ApplyDamage(1);
            Destroy(gameObject);
        }
    }
}
