using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyReplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MyKeyFrame testKey = new MyKeyFrame (1.0f, Vector3.up, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class MyKeyFrame{
	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	public MyKeyFrame (float aTime, Vector3 aPos, Quaternion aRot){
		frameTime = aTime;
		position = aPos;
		rotation = aRot;
	}
}
