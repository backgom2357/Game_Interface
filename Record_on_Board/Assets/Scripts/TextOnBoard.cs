using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOnBoard : MonoBehaviour {

    public Text textonboard;
    public bool tf = true;

	// Update is called once per frame
	void Update ()
    {
        if (TypeName.FinishType && tf)
        {
            textonboard = GameObject.Find("Text").GetComponent<Text>();
            textonboard.text = GameObject.Find("InputText").GetComponent<Text>().text;
            TypeName.FinishType = false;
        }
    }
}
