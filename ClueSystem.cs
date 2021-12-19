using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClueSystem : MonoBehaviour
{
    public GameObject clueCollected;
    public static int numClueCollected;
    public GameObject ExitDoor;

    void Update()      
    {
        clueCollected.GetComponent<Text>().text = "Clues Collected: " + numClueCollected;
        if(numClueCollected == 3)
        {
            ExitDoor.SetActive(true);
        }
    }
}
