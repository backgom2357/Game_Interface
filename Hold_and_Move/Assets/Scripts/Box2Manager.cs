using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box2Manager : MonoBehaviour {


    void Update()
    {
    }

    public static bool StopOrNot = true;

    public static bool StopBox2
    {
        get { return StopOrNot; }
        set { StopOrNot = value; }
    }

    #region SavePositionData

    static public class CircularQueue
    {
        static Vector3[] PositionData = new Vector3[2];
        static int enter = 0;

        public static int Enter { get { return enter; } set { enter = value; } }

        public static Vector3 PositionData1
        {
            get { return PositionData[0]; }
            set { PositionData[0] = value; }
        }

        public static Vector3 PositionData2
        {
            get { return PositionData[1]; }
            set { PositionData[1] = value; }
        }

        public static void Enqueue(Vector3 pos)
        {
            Enter = (Enter + 1) % 2;
            if (Enter == 1)
            {
                PositionData2 = pos;
            }
            else
            {
                PositionData1 = pos;
            }
        }
    }
    #endregion

}
