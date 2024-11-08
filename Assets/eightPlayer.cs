using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class eightPlayer : MonoBehaviour
{
    public TextMeshProUGUI mytext;
    public TextMeshProUGUI buttonText;
    private List<string> Roles = new List<string> { "God Father", "Mafia", "Professional Mafia", "Investigator", "Doctor", "Sniper", "Citizen", "Citizen" };
    private bool showLoading = false;
    public int counter = 0;
    public int initRoleList = 0;

    void Start()
    {
        initRoleList = Roles.Count;
    }

    public void changeText()
    {
        buttonText.text = "next";
        if (counter >= initRoleList)
        {
            mytext.text = "end";
            return;
        }
        if (showLoading)
        {
            showLoading = false;
            mytext.text = "to see next role press the button";
            return;
        }
        mytext.text = Roles[Random.Range(0, Roles.Count)];
        Roles.Remove(mytext.text);
        showLoading = true;
        counter += 1;
    }

    public void RedirectToMenu ()
    {
        SceneManager.LoadScene(1);
    }
}
