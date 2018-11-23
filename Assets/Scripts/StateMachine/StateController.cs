using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour {

    //public State currentState;
    public GameObject[] vegetables;
    public int veggieNum;

	// Use this for initialization
	void Start ()
    {
        vegetables = GameObject.FindGameObjectsWithTag("vegetable");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
