using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

	public float speed;
	public Vector3 axis;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate (axis, speed);
	}
}
