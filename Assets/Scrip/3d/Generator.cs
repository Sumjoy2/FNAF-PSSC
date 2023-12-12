using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    private int generatorAmount;
    public int generatorMax = 1000;
    public bool refueling = false;
    public Life genAmountSlider;

    // Start is called before the first frame update
    void Start()
    {
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
        //caps generator amount at generator max
        if (generatorAmount >= generatorMax)
        {
            generatorAmount = generatorMax;
        }

    }
    //adds 5 per whatever to generator amount
    public void WindUp()
    {
        generatorAmount += 5;
    }
    //makes holding the button work
    public void isRefuling()
    {
        refueling = !refueling;
    }
}
