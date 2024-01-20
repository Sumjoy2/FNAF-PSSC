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
    [NonSerialized] public int nightish = 1;

    [NonSerialized] public static int timeHours;

    public GameObject night;

    public PlayerMovement3D tisBroketh;

    private void Start()
    {
        timeHours = startingTime;
        night.SetActive(false);
        StartCoroutine(advanceHourOverTime());
    }
    private void Update()
    {
        timeText.text = timeHours + ":00 AM";
        if (timeHours == timeLimit)
        {
            nightish++;
            timeHours = 0;
            night.SetActive(true);
        }
    }
    //used to click button to go to next day
    public void newDay()
    {
        day++;
        txt_night.text = "Night " + nightish;
        night.SetActive(false);
        StartCoroutine(advanceHourOverTime());
        //playerMovement.CameraDesk();
        tisBroketh.CameraDesk();

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
