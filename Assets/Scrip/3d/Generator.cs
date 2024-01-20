using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    private int generatorAmount;
    public int generatorMax = 6000;
    public bool refueling = false;
    public GameObject cameras;
    public Life genAmountSlider;

    private NIghtNightTimer nightTimer;

    // Start is called before the first frame update
    void Start()
    {
        nightTimer = GameObject.Find("Wibbly wobbly, timey wimey").GetComponent<NIghtNightTimer>();

        generatorAmount = generatorMax;
        genAmountSlider.SetMaxHealth(generatorMax);
        genAmountSlider.SetHealth(generatorAmount);

    }

    private void FixedUpdate()
    {
        //subtracts from generator amount every fixed update
        generatorAmount--;
        genAmountSlider.SetHealth(generatorAmount);
        //when button held add 5 to generator amount per fixed update
        if (refueling )
        {
            WindUp();
        }
        //caps generator amount at generator max, 
        if (generatorAmount >= generatorMax)
        {
            generatorAmount = generatorMax;
            cameras.SetActive(true);
        }
        //turns cameras off when generator hits 0
        if (generatorAmount <= 0)
        {
            cameras.SetActive(false);
            generatorAmount = 0;
        }
        if (nightTimer.timeHours == 0)
        {
            generatorAmount = generatorMax;
        }
    }
    //adds 5 per whatever to generator amount
    public void WindUp()
    {
        generatorAmount += 25;
    }
    //makes holding the button work
    public void isRefuling()
    {
        refueling = !refueling;
    }
}
