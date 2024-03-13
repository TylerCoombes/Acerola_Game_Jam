using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject SoundMenu;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
        SoundMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void SoundButton()
    {
        SoundMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        SoundMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
