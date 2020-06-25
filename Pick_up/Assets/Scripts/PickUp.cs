using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    static string key = "f";

    // Update is called once per frame
    void Update () {

        GameObject nearestObject = GameObject.Find(NearestObject.NearestObjectName);

        PickItUp(nearestObject);
             
	}

    bool InRangeOfPick(Vector3 A, Vector3 B)
    {
        float pickableDistance = (float)1.5;
        return NearestObject.DistanceBtwAAndB(A, B) < pickableDistance;
    }

    bool IsPickable(GameObject pickableObject)
    {
        return pickableObject != null
            && InRangeOfPick(gameObject.transform.position, pickableObject.transform.position)
            && GameManager.PressOnce(key);
    }

    void PickItUp(GameObject nearestObject)
    {
        if (IsPickable(nearestObject))
        {
            InventroyManager.inventory.Add(NearestObject.NearestObjectName);
            System.IO.File.Copy(@"C:\Users\backg\Documents\PickUp\Assets\Prefabs\" + NearestObject.NearestObjectName+".prefab",
                @"C:\Users\backg\Documents\PickUp\Assets\Resources\Temp\" + NearestObject.NearestObjectName+".prefab");
            Destroy(nearestObject);
        }
    }

}