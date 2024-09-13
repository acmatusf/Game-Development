using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public GameObject GameOverScreen;
    public void restartScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
