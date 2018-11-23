using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSkullTrigger : MonoBehaviour {
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
