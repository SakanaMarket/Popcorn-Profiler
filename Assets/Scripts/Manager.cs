using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private Lerper Linstance;
    [SerializeField] private GameObject c;
    [SerializeField] Text desc;
    [SerializeField] GameObject rbutton;

    private void Update()
    {
        if (CheckLerp() == false)
        {
            StartCoroutine(Wait());
        }
        else
        {
            StopAllCoroutines();
            ChangeText("");
            rbutton.SetActive(false);
        }
    }

    private bool CheckLerp()
    {
        Linstance = c.transform.GetChild(c.transform.childCount - 1).GetComponent<Lerper>();
        return Linstance.ReturnLerp();
    }

    public void ChangeText(string s)
    {
        desc.text = s;
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        rbutton.SetActive(true);
    }

    public void Reveal()
    {
        if (CheckLerp() == false)
        {
            ChangeText(Linstance.ReturnDesc());
        }
        else
        {
            ChangeText("");
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

}
