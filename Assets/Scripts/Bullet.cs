using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;
    [SerializeField] private LayerMask _filter;



    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, _distance, _filter);

        if (hit)
        {
            if (hit.collider.CompareTag("Enemy"))
            {
                hit.collider.GetComponent<Enemy>().ApplyDamage(1);
            }
            Destroy(gameObject);
        }
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
    }

    

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.TryGetComponent(out Enemy enemy))
    //        enemy.ApplyDamage(1);

    //    Debug.Log("----");
    //    Destroy(gameObject);
    //}
}
