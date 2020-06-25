using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class IsStop
{
    public static bool Is_Stop(Vector3 posData1, Vector3 posData2)
    {
        return posData1 == posData2;
    }

    public static bool CanMove()
    {
        if(Box1Manager.StopBox1 && Box2Manager.StopBox2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}
