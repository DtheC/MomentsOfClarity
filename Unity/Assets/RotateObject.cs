using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

	public bool NoiseMovement = false;

	public float speed;
	public Vector3 axis;

	public float NoiseSpeed = 0.01f;
	public float NoiseMultiplier = 10f;

	private float _currentNoiseValue = 0f;

	void FixedUpdate () {
		if (!NoiseMovement) {
			transform.Rotate (axis, speed);
		} else {
			_currentNoiseValue += NoiseSpeed;
			float v = Mathf.PerlinNoise(_currentNoiseValue,0);
			v *= NoiseMultiplier;
			v -= NoiseMultiplier/2;
			Debug.Log (v);
			transform.Rotate (axis, v);
		}
	}
}
