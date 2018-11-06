using UnityEngine;
using UnityEngine.AI;

public class SpiritMovement : MonoBehaviour
{
    private NavMeshAgent _nav;
    private Transform _veggie;

    void Start()
    {
        _nav = GetComponent<NavMeshAgent>();
        _veggie = GameObject.FindGameObjectWithTag("Vegetable").transform;
    }

    void Update()
    {
        _nav.SetDestination(_veggie.position);
    }
}