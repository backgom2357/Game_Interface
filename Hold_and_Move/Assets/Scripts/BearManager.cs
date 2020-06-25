using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearManager : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            while (Once.RunOnce)
            {
                try { HeldObject.HeldObjectName = CollidedObject.ColliOBj.gameObject.name; }
                catch { HeldObject.HeldObjectName = "bear"; }
                Once.RunOnce = false;
            }
        }
        if (Input.GetKeyUp("space"))
        {
            Once.RunOnce = true;
        }

        ObjectPosition.BearPosition = transform.position;
        Hold.HoldSomething();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        CollidedObject.ColliOBj = collision;

    }

}


class CollidedObject
{
    static Collision2D colliObj;

    public static Collision2D ColliOBj
    {
        get { return colliObj; }
        set { colliObj = value; }
    }
}

class HeldObject
{
    static string heldObjectName;

    public static string HeldObjectName
    {
        get { return heldObjectName; }
        set { heldObjectName = value; }
    }
}

class Once
{
    static bool once = true;

    public static bool RunOnce
    {
        get { return once; }
        set { once = value; }
    }
}