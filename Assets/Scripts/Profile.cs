using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profile : MonoBehaviour
{
    [SerializeField] private string first = "";
    [SerializeField] private string last = "";
    [SerializeField] private string hobby = "";
    [SerializeField] private string addr = "";
    [SerializeField] private string city = "";
    [SerializeField] private string state = "";
    [SerializeField] private string zip = "";

    public string ReturnInfo()
    {
        return
            "First Name: " + first + "\n"
            + "Last Name: " + last + "\n"
            + "Hobby: " + hobby + "\n"
            + "\n"
            + "Address: " + addr + "\n"
            + "City: " + city + "\n"
            + "State: " + state + "\n"
            + "Zip Code: " + zip + "\n";

    }
}
