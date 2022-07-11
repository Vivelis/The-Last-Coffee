using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Menu
{
    Nothing = -1,
    Main = 0,
    Options = 1
}

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private List<GameObject> MenuArray;

    public void SetMenu(Menu menu)
    {
        DesactivateAllMenu();
        switch (menu)
        {
            case Menu.Nothing:
                break;
            case Menu.Main:
                MenuArray[(int)Menu.Main].SetActive(true);
                break;
            case Menu.Options:
                MenuArray[(int)Menu.Options].SetActive(true);
                break;
        }
    }

    private void DesactivateAllMenu()
    {
        foreach (GameObject obj in MenuArray)
        {
            obj.SetActive(false);
        }
    }


}
