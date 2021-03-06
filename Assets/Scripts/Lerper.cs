using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lerper : MonoBehaviour
{
    [SerializeField] static private bool shouldLerp = false;
    [SerializeField] Text desc;
    [TextArea(0, 30)]
    [SerializeField] private string d = "";


    public Vector3 endPos;
    [SerializeField] private Vector3 startPos;

    public float timeStartedLerping;
    public float lerpTime;

    public int clicked;

    private void StartLerping()
    {
        timeStartedLerping = Time.time;
        shouldLerp = true;
    }

    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 1)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;
        float percentComplete = timeSinceStarted / lerpTime;
        var result = Vector3.Lerp(start, end, percentComplete);
        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        StartLerping();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldLerp)
        {
            transform.position = Lerp(startPos, endPos, timeStartedLerping, lerpTime);
        }
        else
        {
            transform.position = Lerp(endPos, startPos, timeStartedLerping, lerpTime);
        }
    }

    public void ReverseLerp()
    {
        this.transform.SetSiblingIndex(-1);
        InverseShouldLerp();
        float temporalTime = Time.time;
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("portrait"))
        {
            Lerper b = g.GetComponent<Lerper>();
            b.timeStartedLerping = temporalTime;
        }
    }

    public bool ReturnLerp()
    {
        return shouldLerp;
    }

    public void InverseShouldLerp()
    {
        shouldLerp = !shouldLerp;
    }

    public string ReturnDesc()
    {
        return d;
    }
}
