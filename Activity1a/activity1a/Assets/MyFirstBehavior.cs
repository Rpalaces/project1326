using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstBehavior : MonoBehaviour {

    public int repeatNo = 10;
    public int frame = 0;
	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");

	}
	
	// Update is called once per frame
	void Update () {
        if (frame == 50)
        {
            if (repeatNo > 0)
            {
                Debug.Log(repeatNo);
                repeatNo--;

            }
            frame = 0;
        }
        else if (repeatNo != 0)
            frame++;
    }
}
