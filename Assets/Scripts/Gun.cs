using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _pointSpawnBullet;
    [SerializeField] private float _offset;

    private void Update()
    {
        Vector3 diffrence = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diffrence.y, diffrence.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + _offset);

        if (Input.GetKeyDown(KeyCode.Mouse0))
            Instantiate(_bullet, _pointSpawnBullet.position, transform.rotation);
    }
}
