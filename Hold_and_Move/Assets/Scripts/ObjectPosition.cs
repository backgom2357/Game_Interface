using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public static class ObjectPosition
{
    static Vector3 bearPosition, box1Position, box2Position;

    public static Vector3 Box1Position
    {
        get { return box1Position; }
        set { box1Position = value; }
    }

    public static Vector3 Box2Position
    {
        get { return box2Position; }
        set { box2Position = value; }
    }

    public static Vector3 BearPosition
    {
        get { return bearPosition; }
        set { bearPosition = value; }
    }

}

