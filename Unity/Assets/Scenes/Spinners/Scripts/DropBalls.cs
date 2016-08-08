using UnityEngine;
using System.Collections;

public class DropBalls : MonoBehaviour {

	public float XMin = -15.0f;
	public float XMax = 15.0f;

	public float XSpread = 100f;

	public GameObject DroppedObject;

	public float DropChance = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.Range (0.0f, 1.0f) < DropChance) {
			float xLoc = Random.Range (transform.position.x - (XSpread / 2), transform.position.x + (XSpread / 2));
			Instantiate(DroppedObject, new Vector3(xLoc,transform.position.y,0), Quaternion.identity);
		}
	}
}
