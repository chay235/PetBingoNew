using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuNavigation : MonoBehaviour
{
    public void PlayerLobby()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void GameLobby()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame
    public void QuitGame()
    {
        // Debug.log("QUIT!");
        Application.Quit();
    }
}
