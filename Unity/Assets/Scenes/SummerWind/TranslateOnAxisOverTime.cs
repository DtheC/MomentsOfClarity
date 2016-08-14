using UnityEngine;
using System.Collections;

public class TranslateOnAxisOverTime : MonoBehaviour {

	public Vector3 TranslationAxis;

	public Vector2 NoiseSpeed = new Vector2(0.01f, 0.01f);

	private Vector2 noiseBase = new Vector2(0,0);

	private Vector3 basePosition;

	void Start(){
		basePosition = transform.position;
	}

	void Update () {
		float noise = (Mathf.PerlinNoise (noiseBase.x, noiseBase.y) - 0.5f)*2;
		transform.position = basePosition + (TranslationAxis * noise);
		noiseBase += NoiseSpeed;
	}
}
