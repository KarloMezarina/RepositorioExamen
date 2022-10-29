using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }
}
