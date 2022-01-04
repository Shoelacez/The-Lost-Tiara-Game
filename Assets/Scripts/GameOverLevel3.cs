using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverLevel3 : MonoBehaviour
{

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
