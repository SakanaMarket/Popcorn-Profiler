using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManageInfo : MonoBehaviour
{
    [SerializeField] GameObject showButton;
    [SerializeField] GameObject c; // clipboard parent
    [SerializeField] GameObject redacted;
    [SerializeField] Text Desc;
    private GameObject lastChild;
    [TextArea(0, 30)]
    [SerializeField] string defProfile;

    private void Update()
    {
        //Debug.Log(c.transform.childCount);
        if (CheckLR())
        {
            StopAllCoroutines();
            showButton.SetActive(false);
            HideDesc();
            ChangeProfile(defProfile);
        }
        else
        {
            StartCoroutine(Wait());
        }

    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        showButton.SetActive(true);
        ChangeProfile(lastChild.GetComponent<Profile>().ReturnInfo());
    }

    bool CheckLR()
    {
        lastChild = c.transform.GetChild(c.transform.childCount - 1).gameObject;
        //Debug.Log(lastChild.GetComponent<Transitions>().ReturnLR());
        return lastChild.GetComponent<Transitions>().ReturnLR();
    }

    public void RevealDesc()
    {
        if (Desc.text == "")
        {
            Desc.text = lastChild.GetComponent<Transitions>().ReturnD();
        }
        else
        {
            Desc.text = "";
        }
    }

    public void HideDesc()
    {
        Desc.text = "";
    }
    public void ChangeProfile(string s)
    {
        redacted.GetComponent<TextMeshProUGUI>().text = s;

    }
}
