using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Play : MonoBehaviour
{
     public void Loadscene(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
