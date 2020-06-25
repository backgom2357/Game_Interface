using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour {

    float SpeedPerFrame = 8;

	// Update is called once per frame
	void Update () {

        Vector3 BearPosition = gameObject.transform.position;

        if (Input.GetKey("up"))
        {
            BearPosition.y += SpeedPerFrame * Input.GetAxis("Vertical") * Time.deltaTime;
            transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
        }
        if (Input.GetKey("down"))
        {
            BearPosition.y += SpeedPerFrame * Input.GetAxis("Vertical") * Time.deltaTime;
            transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
        }
        if (Input.GetKey("right"))
        {
            BearPosition.x += SpeedPerFrame * Input.GetAxis("Horizontal") * Time.deltaTime;
            transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
        }
        if (Input.GetKey("left"))
        {
            BearPosition.x += SpeedPerFrame * Input.GetAxis("Horizontal") * Time.deltaTime;
            transform.rotation = Quaternion.AngleAxis(-90, Vector3.forward);
        }

        transform.position = BearPosition;
    
    }
}
