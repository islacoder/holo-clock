using UnityEngine;
using System.Collections;
using System;

public class Clock : MonoBehaviour {
        

    public Transform hoursTransform, minutesTransform, secondsTransform;

    public bool analog;

    private const float hoursFactor= 360f / 12f, minutesFactor = 360f / 60f, secondsFactor = 360f / 60f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (analog)
        {
            TimeSpan t = DateTime.Now.TimeOfDay;
            hoursTransform.localRotation = Quaternion.Euler(0f, 0f, - hoursFactor * (float) t.TotalHours);
            minutesTransform.localRotation = Quaternion.Euler(0f, 0f, -minutesFactor * (float) t.TotalMinutes);
            secondsTransform.localRotation = Quaternion.Euler(0f, 0f, -secondsFactor * (float) t.TotalSeconds);
            Debug.Log((float)t.Minutes  );

        }

	
	}


}
