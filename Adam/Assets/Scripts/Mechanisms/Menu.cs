using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menuPanel;
    public void ActivateMenu()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            menuPanel.SetActive(true);
            //Time.timeScale = 0f;
        }
    }
    public void DeactivateMenu()
    {
        menuPanel.SetActive(false);
        //Time.timeScale = 1f;
    }
    void Update()
    {
        ActivateMenu();
    }
}
