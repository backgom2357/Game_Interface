using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class NearestObject
{
    public static void SaveTheNearestObject(Vector3 objPos, string name)
    {
        if (NearestObject.IsNearestToChara(objPos))
        {
            NearestObject.NearestObjectName = name;
//            Debug.Log("Save! "+ name);
        }
    }

    static bool IsNearestToChara(Vector3 objectPosition)
    {
        if(DistanceBtwAAndB(GameObject.Find("bear").transform.position,objectPosition) == MinDistanceToChara())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static float MinDistanceToChara()
    {
        List<float> test = new List<float>();

        if (GameObject.Find("box1") != null) { test.Add(DistanceBtwAAndB(GameObject.Find("bear").transform.position,GameObject.Find("box1").transform.position)); }
        if (GameObject.Find("box2") != null) { test.Add(DistanceBtwAAndB(GameObject.Find("bear").transform.position,GameObject.Find("box2").transform.position)); }

        return test.Min<float>();
    }

    public static float DistanceBtwAAndB(Vector3 A, Vector3 B)
    {
        return Mathf.Sqrt((A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y));
    }

    private static string nearestObjectName;

    public static string NearestObjectName
    {
        get { return nearestObjectName; }
        set { nearestObjectName = value; }
    }

}

