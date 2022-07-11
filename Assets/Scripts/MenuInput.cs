using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInput : MonoBehaviour
{
    private MenuManager menuManager;

    private void Start()
    {
        menuManager = GetComponent<MenuManager>();
    }

    public void ClickPlay()
    {
        menuManager.SetMenu(Menu.Nothing);
    }
}
