using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject preferencesPanel;
    public GameObject menuPanel;
    private bool _activePrefPanel = false;
  





    public void ActivatePreferencesPanel()
    {
        if (_activePrefPanel)
        {
            preferencesPanel.SetActive(true);
        }
        else
        {
            preferencesPanel.SetActive(false);
        }
        _activePrefPanel = !_activePrefPanel;
    }


    public void ActivateMenuButton()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            ActivateMenu();
        }
    }

    public void ActivateMenu()
    {
        menuPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Reastart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void DeactivateMenu()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    private void Start()
    {
        ActivateMenu();
    }
    void Update()
    {
        ActivateMenuButton();
    }
}
