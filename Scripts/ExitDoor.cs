using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public GameObject HealthBarUi;
    public GameObject LiveUi;
    public GameObject EscapedScreen;
    public GameObject clueCollected;
    void OnTriggerEnter(Collider other)
    {
        HealthBarUi.SetActive(false);
        LiveUi.SetActive(false);
        clueCollected.SetActive(false);
        EscapedScreen.SetActive(true);
    }
}
