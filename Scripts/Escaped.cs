using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escaped : MonoBehaviour
{
    public void MainMenuButton()
    {
        ClueSystem.numClueCollected = 0;
        SceneManager.LoadScene("Menu");
    }
}
