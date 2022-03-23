using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _cameraSpeed;

    private Vector3 _targetPosition;

    private void Update()
    {
        _targetPosition = new Vector3(_player.transform.position.x, _player.transform.position.y, -10);
        transform.position = Vector3.Lerp(transform.position, _targetPosition, _cameraSpeed * Time.deltaTime);
    }
}
