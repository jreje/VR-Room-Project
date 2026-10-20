using System;
using UnityEngine;

public class Clock_Script : MonoBehaviour
{
    public GameObject minHand;
    public GameObject hourHand;
    public GameObject secondHand;
    private DateTime time;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        secondHand.transform.Rotate(-time.Second * 6, 0, 0);
        minHand.transform.Rotate(-time.Minute * 6, 0, 0);
        hourHand.transform.Rotate(-time.Hour * 30, 0, 0);
    }
}
