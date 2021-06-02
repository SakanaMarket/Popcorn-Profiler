using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerper : MonoBehaviour
{
    private bool shouldLerp = false;

    public Vector2 endPos;
    public Vector2 startPos;

    public float timeStartedLerping;
    public float lerpTime;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldLerp)
        {
            transform.position = Lerp(startPos, endPos, timeStartedLerping, lerpTime);
        }
    }
}
