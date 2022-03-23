using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyContoller : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _distance;

    private NavMeshAgent _navMeshAgent;

    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.updateRotation = false;
        _navMeshAgent.updateUpAxis = false;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, _player.position) < _distance)
            _navMeshAgent.SetDestination(_player.position);          
    }

}
