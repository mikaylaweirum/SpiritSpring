using UnityEngine;
using UnityEngine.AI;

public class FindVeggies : MonoBehaviour
{
    private NavMeshAgent _nav;
    GameObject[] veggiePoints;
    GameObject currentVeggie;
    private Transform _veggie;

    int index;


    void Start()
    {
        _nav = GetComponent<NavMeshAgent>();
        veggiePoints = GameObject.FindGameObjectsWithTag("Vegetable");
        index = Random.Range(0, veggiePoints.Length);

        currentVeggie = veggiePoints[index];

        _veggie = currentVeggie.transform;
        Debug.Log(_veggie.position);
    }

    void Update()
    {
        _nav.SetDestination(_veggie.position);
    }
}