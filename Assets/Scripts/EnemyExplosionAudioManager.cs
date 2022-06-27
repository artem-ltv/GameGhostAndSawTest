using UnityEngine;

public class EnemyExplosionAudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource _explosionAudioSource;

    private Enemy[] _enemies;

    private void Awake() =>
        _enemies = GameObject.FindObjectsOfType<Enemy>();    
    

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
     

    private void OnSoundExplosion()
    {

        Debug.Log("OnSoundExplosion");
        _explosionAudioSource.Play();
    }

}
