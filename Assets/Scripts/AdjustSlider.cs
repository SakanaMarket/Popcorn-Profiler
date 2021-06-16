using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustSlider : MonoBehaviour
{
    private void Awake()
    {
        Slider s = GetComponent<Slider>();
        s.value = GameObject.FindGameObjectWithTag("music").GetComponent<Volume>().GetVolume();
        s.onValueChanged.AddListener(delegate { GameObject.FindGameObjectWithTag("music").GetComponent<Volume>().AdjustVolume(); } );
        Debug.Log("success");
    }
}
