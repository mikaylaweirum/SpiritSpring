using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spells : MonoBehaviour {
    public GameObject aSpellPrefab;
    public GameObject bSpellPrefab;
    public Transform spellSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            SpellA();
        }else if (OVRInput.Get(OVRInput.Button.Two))
        {
            SpellB();
        }
    }
    void SpellA()
    {
        var spell = (GameObject)Instantiate(
            aSpellPrefab,
            spellSpawn.position,
            spellSpawn.rotation);

        spell.GetComponent<Rigidbody>().velocity = spellSpawn.forward * 6;

        Destroy(spell, 2.0f);
    }
    void SpellB()
    {
        var spell = (GameObject)Instantiate(
            bSpellPrefab,
            spellSpawn.position,
            spellSpawn.rotation);

        spell.GetComponent<Rigidbody>().velocity = spellSpawn.forward * 6;

        Destroy(spell, 2.0f);
    }
}
