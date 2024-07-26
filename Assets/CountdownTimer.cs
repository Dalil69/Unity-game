using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Utilisation de TMPro pour TextMeshPro

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 60;
    public TMP_Text countdownText; // Utilisation de TMP_Text pour TextMeshPro
    public GameController gameController; // Référence au GameController

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            countdownText.text = "Time: " + Mathf.Floor(timeRemaining).ToString();
        }
        else
        {
            gameController.TimerEnded(); // Appel à TimerEnded du GameController
        }
    }
}
