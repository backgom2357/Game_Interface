using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool pressOnce = true;

    public static bool PressOnce(string key)
    {
        if (Input.GetKeyUp(key))
        {
            pressOnce = true;
        }
        if (Input.GetKeyDown(key) && pressOnce)
        {
            pressOnce = false;
            return true;
        }
        else
        {
            return false;
        }
    }

}
