using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class DayNightCycle : MonoBehaviour {



    public float time;
    public TimeSpan currentTime;
    public Transform SunReansform;
    public Light SunLight;
    public Text TimeText;
    public int days;
    public float intensity;
    public Color fogDay = Color.grey;
    public Color fogNight = Color.black;
    public int speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TimeChange();
	}
    
    public void TimeChange()
    {
        time += Time.deltaTime * speed;
        if(time < 86400)
        {
            days += 1;
            time = 0;
        }
        currentTime = TimeSpan.FromSeconds(time);
        currentTime.ToString();
       // string[] timespan = currentTime.ToString;



    }


}
