using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _pointSpawnBullet;
    [SerializeField] private float _offset;
    [SerializeField] private AudioClip _shotSound;
    [SerializeField] private Player _player;

    private AudioSource _shootAudioSource;
    private bool _isShooting;

    private void Start()
    {
        _shootAudioSource = GetComponent<AudioSource>();
        _isShooting = true;
    }

    private void OnEnable() =>
        _player.PlayerDie += BlockShoot;

    private void OnDisable() =>
        _player.PlayerDie -= BlockShoot;

    private void Update()
    {
        Vector3 diffrence = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diffrence.y, diffrence.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + _offset);

        if (_isShooting)
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(_bullet, _pointSpawnBullet.position, transform.rotation);
                _shootAudioSource.PlayOneShot(_shotSound);
            }     
    }

    private void BlockShoot() =>
        _isShooting = false;
}
