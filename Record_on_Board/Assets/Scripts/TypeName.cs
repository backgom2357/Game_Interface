using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class TypeName : MonoBehaviour
{

    public void StoreName()
    {
        Debug.Log("Hello");
        FinishType = true;
    }

    static bool finishType;

    public static bool FinishType
    {
        get { return finishType; }
        set { finishType = value; }
    }

}