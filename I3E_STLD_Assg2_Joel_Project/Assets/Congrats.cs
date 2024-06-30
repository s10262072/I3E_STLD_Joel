/*
 * Author: Leo Shao Wei Joel
 * Date: 30/06/2024
 * Description: Congrats Scene
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Congrats : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource soundPlayer;
    public GameObject CongratsMenuUI;
    void Start()
    {
        Cursor.visible = true;
        Canvas canvas = CongratsMenuUI.GetComponent<Canvas>();
        if (canvas != null)
        {
            canvas.sortingOrder = 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void playThisSoundEffect()
    {
        soundPlayer.Play();

    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        SceneManager.LoadScene(0);
    }
}
