using System;
using System.Collections;
using TMPro;
using UnityEngine;



public class NIghtNightTimer : MonoBehaviour
{
  
    [SerializeField] private int startingTime;
    [SerializeField] private float timeUntilHourChange;
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private int timeLimit;
    [SerializeField] private TMP_Text txt_night;

    int day = 1;


    [NonSerialized] public int timeHours;


    public GameObject night;

    private void Start()
    {
        night.SetActive(false);
        timeHours = startingTime;
        StartCoroutine(advanceHourOverTime());

    }
    private void Update()
    {
        timeText.text = timeHours + ":00 AM";
        if (timeHours == timeLimit)
        {
            night.SetActive(true);
        }
    }
    //used to click button to go to next day
    public void newDay()
    {
        day++;
      
       night.SetActive(false);
       
    }

    private IEnumerator advanceHourOverTime()
    {
        yield return new WaitForSeconds(timeUntilHourChange);

        if (timeHours == 12)
            timeHours = 1;
        else
            timeHours++;

        if (timeHours < timeLimit)
            StartCoroutine(advanceHourOverTime());
    }
  
}
