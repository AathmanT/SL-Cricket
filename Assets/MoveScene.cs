﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().velocity = new Vector3(0, -GM.verticalVelocity * GM.zVelocityAdjustment, -4 * GM.zVelocityAdjustment);
    }
}