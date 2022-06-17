using UnityEngine;

public class EnemyExplosionAudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource _explosionAudioSource;
    [SerializeField] private AudioClip _explosionSound;
    
    [SerializeField] private Enemy[] _enemies;

    private void Start()
    {
        _enemies = GameObject.FindObjectsOfType<Enemy>();
    }

    private void OnEnable()
    {
        foreach (var enemy in _enemies)
            enemy.Dying += OnSoundExplosion;
    }

    private void OnDisable()
    {
        foreach (var enemy in _enemies)
            enemy.Dying -= OnSoundExplosion;
    }
     

    private void OnSoundExplosion() =>
        _explosionAudioSource.PlayOneShot(_explosionSound);

}
