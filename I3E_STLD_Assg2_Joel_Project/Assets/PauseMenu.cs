using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public AudioSource soundPlayer;
    public List<GameObject> otherCanvases;

    private void Start()
    {
        Cursor.visible = true;
        Canvas canvas = pauseMenuUI.GetComponent<Canvas>();
        if (canvas != null)
        {
            canvas.sortingOrder = 100;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        foreach (var canvas in otherCanvases)
        {
            if (canvas != null)
            {
                canvas.SetActive(true);
            }
        }
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        foreach (var canvas in otherCanvases)
        {
            if (canvas != null)
            {
                canvas.SetActive(false);
            }
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        SceneManager.LoadScene(0);
    }
    public void playThisSoundEffect()
    {
        soundPlayer.Play();

    }



}
