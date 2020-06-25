using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box2Manager : MonoBehaviour {

    void Update()
    {
        NearestObject.SaveTheNearestObject(gameObject.transform.position, gameObject.name);
    }
}
