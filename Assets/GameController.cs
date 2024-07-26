using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject defeatPanel;
    public GameObject victoryPanel;
    private int totalCollectables;
    private int collectablesCollected;

    void Start()
    {
        totalCollectables = GameObject.FindGameObjectsWithTag("Collectable").Length;
    }

    public void CollectItem()
    {
        collectablesCollected++;
        if (collectablesCollected >= totalCollectables)
        {
            Victory();
        }
    }

    public void TimerEnded()
    {
        Defeat();
    }

    void Victory()
    {
        victoryPanel.SetActive(true);
        Time.timeScale = 0f; // Arrêter le temps
    }

    void Defeat()
    {
        defeatPanel.SetActive(true);
        Time.timeScale = 0f; // Arrêter le temps
    }
}
