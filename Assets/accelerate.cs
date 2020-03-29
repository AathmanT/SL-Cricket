using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(gameObject.name=="joint_HipLT"){
            transform.Rotate(300,0, zAngle: 0);
        }
			foreach (Transform child in transform)
             print("Foreach loop: " + child);
			
	}
	
	// Update is called once per frame
	void Update () {
		
		// print(Time.deltaTime);
	
	}
}
