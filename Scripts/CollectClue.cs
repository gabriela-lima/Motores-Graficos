using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectClue : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        ClueSystem.numClueCollected += 1;
        Destroy(gameObject);
    }
}
