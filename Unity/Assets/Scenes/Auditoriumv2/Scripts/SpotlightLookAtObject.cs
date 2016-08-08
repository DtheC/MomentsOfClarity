using UnityEngine;
using System.Collections;

public class SpotlightLookAtObject : MonoBehaviour {

	public Transform TargetObject;

	void Update () {
		transform.LookAt (TargetObject);
	}
}
