using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject normalScreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            endScreen.SetActive(true);
            normalScreen.SetActive(false);
            //should pause the game
            Time.timeScale = 0;
        }
    }
}
