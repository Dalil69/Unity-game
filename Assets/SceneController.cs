using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        UnityEngine.Application.Quit(); // Sp�cifiez explicitement l'espace de noms pour �viter l'ambigu�t�
    }
}
