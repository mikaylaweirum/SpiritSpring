using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritSpawner : MonoBehaviour {

    GameObject[] spawnPoints;
    GameObject newSpawn;
    int index;

    public int availableSpirits = 15;
    public int maxSpirits = 5;
    int currentSpirits = 0;
    int lifetimeSpirits;

    List<GameObject> existingSpirits;

    public GameObject spiritToSpawn;


    public float targetTime = 20.0f;


    // Use this for initialization
    void Start () {
        spawnPoints = GameObject.FindGameObjectsWithTag("Shrine");
        index = Random.Range(0, spawnPoints.Length);
        
    }
	
	// Update is called once per frame
	void Update () {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            SpawnSpirit();
        }
    }

    void SpawnSpirit()
    {
        //if(existingSpirits.Count <= maxSpirits && lifetimeSpirits <= availableSpirits)
        //{
            index = Random.Range(0, spawnPoints.Length);
            newSpawn = spawnPoints[index];
            spiritToSpawn = Instantiate(spiritToSpawn);

            spiritToSpawn.transform.position = newSpawn.transform.position;
            
            lifetimeSpirits++;
            targetTime = 20.0f;
        //}

    }
}
