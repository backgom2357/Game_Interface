using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour {

    float SpeedPerFrame = 5;

    // Update is called once per frame
	void Update () {

        Vector3 position = transform.position;

        if (Input.GetKey("up"))
        {
            position.y += SpeedPerFrame * Input.GetAxis("Vertical") * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            position.y += SpeedPerFrame * Input.GetAxis("Vertical") * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            position.x += SpeedPerFrame * Input.GetAxis("Horizontal") * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            position.x += SpeedPerFrame * Input.GetAxis("Horizontal") * Time.deltaTime;
        }
        transform.position = position;
    }
}
