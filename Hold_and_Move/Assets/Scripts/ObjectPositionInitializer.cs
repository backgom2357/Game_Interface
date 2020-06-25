using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPositionInitializer : MonoBehaviour {

    public static void PositionInit()
    {
        ObjectPosition.Box1Position = GameObject.Find("box1").transform.position;
        ObjectPosition.Box2Position = GameObject.Find("box2").transform.position;
    }

}
