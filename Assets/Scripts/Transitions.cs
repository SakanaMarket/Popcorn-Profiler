using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transitions : MonoBehaviour
{
    private static bool LR;
    [TextArea(0, 30)]
    [SerializeField] private string d = "";
    [SerializeField] Animator ani;

    private void Update()
    {
        LR = ani.GetBool("Right");
        //Debug.Log(LR);
    }
    public void SetRight()
    {
        if (ani.GetBool("Right") == false)
        {
            //ani.SetBool("Right", true);
            SetAll(true);
        }
        else
        {
            StopAllCoroutines();
            this.transform.SetSiblingIndex(-1);
            //ani.SetBool("Right", false);
            SetAll(false);
            
        }
    }

    public bool ReturnLR()
    {
        return LR;
    }

    private void SetAll(bool b)
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("portrait"))
        {
            g.GetComponent<Animator>().SetBool("Right", b);
        }
    }

    public string ReturnD()
    {
        return d;
    }

    


}
