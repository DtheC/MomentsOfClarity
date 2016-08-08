using UnityEngine;
using System.Collections;


namespace Spinners{
public class Fin : MonoBehaviour {

	void Start () {
			transform.Rotate (Vector3.back*Random.Range(0,360f), Space.World);
	}
	
}
}