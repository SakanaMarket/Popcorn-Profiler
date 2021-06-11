using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{
    //[SerializeField] private Lerper Linstance;
    [SerializeField] private GameObject currentProf;
    [SerializeField] private GameObject c; //cavnas
    [SerializeField] Text desc;
    [TextArea(0, 30)]
    [SerializeField] string defProfile;
    [SerializeField] GameObject profile;
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
            ChangeProfile(defProfile);
            rbutton.SetActive(false);
        }
    }

    private bool CheckLerp()
    {
        //Linstance = c.transform.GetChild(c.transform.childCount - 1).GetComponent<Lerper>();
        currentProf = c.transform.GetChild(c.transform.childCount - 1).gameObject;
        if (currentProf)
        {
            return currentProf.GetComponent<Lerper>().ReturnLerp();
        }
        else
        {
            return false;
        }
    }

    public void ChangeText(string s)
    {
        desc.text = s;
    }

    public void ChangeProfile(string s)
    {
        if (profile)
        {
            profile.GetComponent<TextMeshProUGUI>().text = s;
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        rbutton.SetActive(true);
        ChangeProfile(currentProf.GetComponent<Profile>().ReturnInfo());

    }

    public void Reveal()
    {
        if (CheckLerp() == false)
        {
            ChangeText(currentProf.GetComponent<Lerper>().ReturnDesc());
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
