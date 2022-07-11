using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private MenuManager menuManager;

    private void Start()
    {
        if (menuManager == null)
        {
            Debug.LogWarning("Error: Missing MenuManager.");
            Application.Quit();
        }
    }
}
