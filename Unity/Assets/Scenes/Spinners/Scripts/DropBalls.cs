using UnityEngine;
using System.Collections;

public class DropBalls : MonoBehaviour {

	public float XMin = -15.0f;
	public float XMax = 15.0f;

	public GameObject DroppedObject;

	public float DropChance = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.Range (0.0f, 1.0f) < DropChance) {
			Instantiate(DroppedObject, new Vector3(Random.Range(XMin, XMax),40,0), Quaternion.identity);
		}
	}
}
