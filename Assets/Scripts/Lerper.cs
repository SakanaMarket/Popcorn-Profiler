using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lerper : MonoBehaviour
{
    static int c;
    [SerializeField] static private bool shouldLerp = false;

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
            //transform.position = Lerp(c.ScreenToWorldPoint(startPos), c.ScreenToWorldPoint(endPos), timeStartedLerping, lerpTime);
            //transform.position = Lerp(c.ScreenToViewportPoint(startPos), c.ScreenToViewportPoint(endPos), timeStartedLerping, lerpTime);
        }
        else
        {
            transform.position = Lerp(endPos, startPos, timeStartedLerping, lerpTime);
            //transform.position = Lerp(c.ScreenToWorldPoint(endPos), c.ScreenToWorldPoint(startPos), timeStartedLerping, lerpTime);
            //transform.position = Lerp(c.ScreenToViewportPoint(startPos), c.ScreenToViewportPoint(endPos), timeStartedLerping, lerpTime);
        }
    }

    public void ReverseLerp()
    {
        /*timeStartedLerping = Time.time;
        shouldLerp = !shouldLerp;*/
        if (shouldLerp == true)
        {
            c = clicked;
        }
        InverseShouldLerp();
        float temporalTime = Time.time;
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("portrait"))
        {
            Lerper b = g.GetComponent<Lerper>();
            b.timeStartedLerping = temporalTime;
            
        }
    }

    public int ReturnC()
    {
        return c;
    }

    public bool ReturnLerp()
    {
        return shouldLerp;
    }

    public void InverseShouldLerp()
    {
        shouldLerp = !shouldLerp;
    }
}
