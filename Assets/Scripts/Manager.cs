using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private List<Button> buttonsList;
    [SerializeField] private bool profiling;

    private void Awake()
    {
        foreach( Button b in buttonsList)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
