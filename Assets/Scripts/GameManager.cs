using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private MenuManager menuManager;

    private void Start()
    {
        if (GameObject.FindGameObjectsWithTag("GameController").Length > 1)
        {
            Debug.LogWarning("Error: To Many instances of GameManager.");
            Application.Quit();
        }
        if (menuManager == null)
        {
            Debug.LogWarning("Error: Missing MenuManager.");
            Application.Quit();
        }
        if (GameObject.FindGameObjectsWithTag("Player").Length > 1)
        {
            Debug.LogWarning("Error: To Many instances of Player.");
            Application.Quit();
        }
    }
}
