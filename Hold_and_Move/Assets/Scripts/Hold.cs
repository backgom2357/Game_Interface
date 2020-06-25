using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Hold
{
    static bool KeyDown = false;
    public static void HoldSomething()
    {
        try
        {
            if (Input.GetKeyDown("space"))
            {
                KeyDown = true;
            }
            else if (Input.GetKeyUp("space"))
            {
                KeyDown = false;
            }

            if (KeyDown)
            {
                GameObject.Find(HeldObject.HeldObjectName).transform.position = HeldObjectPosition(GameObject.Find(HeldObject.HeldObjectName).transform.position);
            }
        }
        catch
        {
            throw;
        }
    }

    public static float DistanceBtwBearAndObject(Vector3 position)
    {
        float distance = Mathf.Sqrt((ObjectPosition.BearPosition.x - position.x) * (ObjectPosition.BearPosition.x - position.x) + (ObjectPosition.BearPosition.y - position.y) * (ObjectPosition.BearPosition.y - position.y));
        return distance;
    }

    public static Vector3 HeldObjectPosition(Vector3 heldObject)
    {
        Vector3 position = heldObject;

        float HoldPositioin = (float)1;

        if (DistanceBtwBearAndObject(heldObject) < 1.5 && DistanceBtwBearAndObject(heldObject) > 0)
        {

            if (Input.GetKey("up"))
            {
                position = new Vector3(ObjectPosition.BearPosition.x, ObjectPosition.BearPosition.y + HoldPositioin);
            }
            if (Input.GetKey("down"))
            {
                position = new Vector3(ObjectPosition.BearPosition.x, ObjectPosition.BearPosition.y - HoldPositioin);
            }
            if (Input.GetKey("right"))
            {
                position = new Vector3(ObjectPosition.BearPosition.x + HoldPositioin, ObjectPosition.BearPosition.y);
            }
            if (Input.GetKey("left"))
            {
                position = new Vector3(ObjectPosition.BearPosition.x - HoldPositioin, ObjectPosition.BearPosition.y);
            }
            return position;
        }
        else
        {
            HeldObject.HeldObjectName = "bear";
            return position;
        }
    }

}