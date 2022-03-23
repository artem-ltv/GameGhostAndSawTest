using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Vector3 _targetPosition;

    private void Update()
    {
        _targetPosition.x = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        _targetPosition.y = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Translate(_targetPosition);

        if (Input.GetKeyDown(KeyCode.E))
            transform.rotation = Quaternion.identity;
    }
}
