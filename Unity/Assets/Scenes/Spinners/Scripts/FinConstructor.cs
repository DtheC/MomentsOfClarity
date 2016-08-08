using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinConstructor : MonoBehaviour {

	public GameObject FinObject;

	public int FinXNumber = 10;
	public int FinYNumber = 10;

	private IList<GameObject> fins;

	void Start () {
		fins = new List<GameObject> ();
		for (int x = 0; x < FinXNumber; x++) {
			for (int y = 0; y < FinYNumber; y++) {
				Vector3 pos = new Vector3 (x * 6.5f, y * 6f, 0);
				if (y % 2 == 0) {
					pos.x += 3.25f;
				}
				GameObject g = Instantiate (FinObject, pos, Quaternion.Euler(0, 90, 90)) as GameObject;
				fins.Add (g);
			}
		}
	}

}
