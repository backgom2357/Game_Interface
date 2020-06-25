using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box1Manager : MonoBehaviour {

    void Update()
    {
        NearestObject.SaveTheNearestObject(gameObject.transform.position, gameObject.name);
    }
}
