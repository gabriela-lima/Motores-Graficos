using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void RestartButton()
    {
        ClueSystem.numClueCollected = 0;
        SceneManager.LoadScene("Game");
    }
    public void MainMenuButton()
    {
        ClueSystem.numClueCollected = 0;
        SceneManager.LoadScene("Menu");
    }
}
