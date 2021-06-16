using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GeneralManagement : MonoBehaviour
{
    [SerializeField] private GameObject slider;
     public void Loadscene(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ShowSlider()
    {
        slider.SetActive(!slider.activeSelf);
    }

}
