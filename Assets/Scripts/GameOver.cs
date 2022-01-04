using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text scoreDisplay;

    void Start()
    {
        scoreDisplay.text = FindObjectOfType<Score>().coinsPicked.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
