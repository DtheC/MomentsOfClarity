using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateGridOfObjects : MonoBehaviour {

	public GameObject ObjectToConstruct;

	public int ObjectXNumber = 10;
	public int ObjectYNumber = 10;

	public float SpacingX = 6.5f;
	public float SpacingY = 6.0f;

	public bool OffsetRows = true;

	private IList<GameObject> gridObjects;

	void Start () {
		gridObjects = new List<GameObject> ();
		for (int x = 0; x < ObjectXNumber; x++) {
			for (int y = 0; y < ObjectYNumber; y++) {
				Vector3 pos = new Vector3 (x * SpacingX,0, y * SpacingY);
				if (OffsetRows) {
					if (y % 2 == 0) {
						pos.x += (SpacingX / 2.0f);
					}
				}
				GameObject g = Instantiate (ObjectToConstruct, pos, Quaternion.identity) as GameObject;
				gridObjects.Add (g);
			}
		}
	}
}
