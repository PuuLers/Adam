using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    public GameObject skillsPanel;
    public GameObject[] skills;
    public Transform point1;
    public Transform point2;
    public Transform point3;

    public void ActivateSkillsPanel()
    {
        skillsPanel.SetActive(true);
    }

    public void DeactivateSkillsPanel()
    {
        skillsPanel.SetActive(false);
    }

    private void Generate()
    {

        Random.Range(0, skills.Length);
        Instantiate(skills[Random.Range(0, skills.Length)], point1);
        Instantiate(skills[Random.Range(0, skills.Length)], point2);
        Instantiate(skills[Random.Range(0, skills.Length)], point3);
    }




    void Update()
    {
        
    }
}
