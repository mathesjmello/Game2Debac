using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceSys : MonoBehaviour
{
    public GameObject MenuPause;
    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Cena_Valeno");
    }

    public void OpenMenu()
    {
        Time.timeScale = 0;
        MenuPause.SetActive(true);
    }

    public void CloseMenu()
    {
        Time.timeScale = 1;
        MenuPause.SetActive(false);
    }
}
