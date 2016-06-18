using UnityEngine;
using System.Collections;

public class BounceObject : MonoBehaviour {

	public bool Bounce = false;
	public float NoiseSpeed = 0.01f;
	public float NoiseStrength = 10.0f;

	private float noiseValue = 0;
	private float noiseTime = 0;

	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Bounce) {
			if (Random.Range (0.0f, 1.0f) < 0.2f) {
				noiseTime += NoiseSpeed;
				noiseValue += NoiseSpeed;
				float t = Mathf.PerlinNoise (noiseValue, noiseTime);
				t *= NoiseStrength;

				if (transform.position.y < 4){
					GetComponent<Rigidbody> ().AddForce (new Vector3 (0, t, 0));
				}
			}
		}
	}
}
