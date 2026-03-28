using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionMenu;

    public void OpenOption()
    {
        mainMenu.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void CloseOption()
    {
        mainMenu.SetActive(true);
        optionMenu.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Keluar");
    }
}
