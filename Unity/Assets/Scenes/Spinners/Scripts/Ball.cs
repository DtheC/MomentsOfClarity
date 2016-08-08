using UnityEngine;
using System.Collections;

namespace Spinners{

public class Ball : MonoBehaviour {
		void Update () {
			if (transform.position.y < -100) {
				Destroy(gameObject);
			}
		}
	}
}