using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour {
    public bool beginningQuest = false;
    public GameObject SurroundingBathwater;
    public GameObject CleanBathwater;

    private void Start()
    {
        CleanBathwater.SetActive(false);
        SurroundingBathwater.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        QuestCompletion.questOne = true;
        gameObject.SetActive(false);
        CleanBathwater.SetActive(true);
        SurroundingBathwater.SetActive(true);
    }
}
