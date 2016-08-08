using UnityEngine;
using System.Collections;

namespace Spinners{
	
public class Ball : MonoBehaviour {
		public float YDestructionPosition = -200f;
		void Update () {
			if (transform.position.y < YDestructionPosition) {
				Destroy(gameObject);
			}
		}
	}
}