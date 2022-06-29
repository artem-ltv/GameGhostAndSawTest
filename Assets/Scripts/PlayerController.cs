using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Player _player;
    private Vector3 _targetPosition;
    private bool _isMovement;

    private void Awake()
    {
        _player = GetComponent<Player>();
        _isMovement = true;
    }

    private void OnEnable() =>
        _player.PlayerDie += BlockMovement;

    private void OnDisable() =>
        _player.PlayerDie -= BlockMovement;

    private void Update()
    {
        if (_isMovement)
        {
            _targetPosition.x = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
            _targetPosition.y = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

            transform.Translate(_targetPosition);
            transform.rotation = Quaternion.identity;
        }
    }

    private void BlockMovement() =>
        _isMovement = false;
}
