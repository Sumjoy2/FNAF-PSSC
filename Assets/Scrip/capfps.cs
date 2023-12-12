using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capfps : MonoBehaviour
{
    public int targetFPS = 60;
   
    void start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFPS;
    }

}
