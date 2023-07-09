using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    public void resetScene()
    {
        lifeManager.lifes = 4;
        lifeManager.endSignal = false;
    }
}
