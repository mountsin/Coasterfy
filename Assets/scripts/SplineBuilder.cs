﻿using UnityEngine;
using System.Collections;

public class SplineBuilder : MonoBehaviour {
	static public float splinenumber;
	// Use this for initialization
	void Start () {
		name = (splinenumber + "point");


		transform.parent = GameObject.Find("SplineRoot").transform;


		splinenumber=splinenumber + 0.0001f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
