using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private List<Button> buttonsList;
    [SerializeField] private bool profiling;
    [SerializeField] private Lerper Linstance;

    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Linstance.ReturnC());
        if (Linstance.ReturnLerp() == false)
        {
            Debug.Log("false");
            DisableNonClicked();
        }
        else
        {
            Debug.Log("true");
            EnabledAll();
        }
    }

    public void DisableNonClicked()
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("portraits"))
        {
            if (g.GetComponent<Lerper>().clicked != g.GetComponent<Lerper>().ReturnC())
            {
                Debug.Log("here");
                g.SetActive(false);
            }
        }
    }

    public void EnabledAll()
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("portraits"))
        {
            g.SetActive(true);
        }
    }
}
