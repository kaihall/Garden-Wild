using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float dayLength = 1f;
    public float currentDay = 0;
    public string currentTool = "Hand";
    public string currentSeed = "Generic";

    private float lastDayAdvanceTime = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        lastDayAdvanceTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastDayAdvanceTime > dayLength)
        {
            lastDayAdvanceTime = Time.time;
            currentDay++;
            //Debug.Log("Day " + currentDay);
        }
    }
}
