using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void RestartGame()
    {
        // Load the game scene when the restart button is pressed
        SceneManager.LoadScene(1); // Replace "GameScene" with the name of your game scene
    }
    public void BackToMainMenu()
    {
        
        SceneManager.LoadScene(0);
    }
}
