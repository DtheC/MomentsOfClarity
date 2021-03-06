﻿using UnityEngine;
using System.Collections;

public enum DropFunction{
	Random,
	Noise,
	Sine,
	Limit,
	LimitWithSine
}

public class DropBalls : MonoBehaviour {

	public DropFunction dropfunction = DropFunction.Noise;

	public float XSpread = 100f;

	public GameObject DroppedObject;

	public float DropChance = 0.5f;

	private float noiseX = 0f;
	private float noiseY = 0f;
	public float NoiseSpeed = 0.01f;

	private float sinCount = 0;
	public float SinSpeed = 0.01f;
	private int sinBallDropCount = 0;

	public int BallLimit = 1000;
	private int ballLimitMax = 0;

	void Start(){
		ballLimitMax = BallLimit;
	}

	void Update () {
		switch (dropfunction) {
		case DropFunction.Random:
			DropRandom ();
			break;
		case DropFunction.Noise:
			DropNoise ();
			break;
		case DropFunction.Sine:
			DropSine ();
			break;
		case DropFunction.Limit:
			DropLimit ();
			break;
		case DropFunction.LimitWithSine:
			DropLimitWithSineFalloff ();
			break;
		default:
			break;
		}
	}

	void DropNoise(){
		if (Time.frameCount % 100 == 0){
			float noise = Mathf.PerlinNoise (noiseX, noiseY);
			Debug.Log (noise);

			for (int i = 0; i < noise * 10; i++) {
				float xLoc = Random.Range (transform.position.x - (XSpread / 2), transform.position.x + (XSpread / 2));
				Instantiate (DroppedObject, new Vector3 (xLoc, transform.position.y, 0), Quaternion.identity);
			}

			noiseX += NoiseSpeed;
			noiseY += NoiseSpeed;
		}
	}

	void DropRandom(){
		if (Random.Range (0.0f, 1.0f) < DropChance) {
			float xLoc = Random.Range (transform.position.x - (XSpread / 2), transform.position.x + (XSpread / 2));
			Instantiate (DroppedObject, new Vector3 (xLoc, transform.position.y, 0), Quaternion.identity);
		}
	}

	void DropSine(){
		if (Time.frameCount % 100 == 0) {
			float sine = Mathf.Abs (Mathf.Sin (sinCount));
			sinBallDropCount += (int)(sine * 100);
			Debug.Log (sine);
			sinCount += SinSpeed;
		}
		if (sinBallDropCount > 0) {
			sinBallDropCount--;
			float xLoc = Random.Range (transform.position.x - (XSpread / 2), transform.position.x + (XSpread / 2));
			Instantiate (DroppedObject, new Vector3 (xLoc, transform.position.y, 0), Quaternion.identity);
		}
	}

	void DropLimit(){
		if (BallLimit > 0) {
			if (Random.Range (0.0f, 1.0f) < DropChance) {
				BallLimit--;
				float xLoc = Random.Range (transform.position.x - (XSpread / 2), transform.position.x + (XSpread / 2));
				Instantiate (DroppedObject, new Vector3 (xLoc, transform.position.y, 0), Quaternion.identity);
			}
		}
	}

	void DropLimitWithSineFalloff(){
		if (BallLimit > 0) {
			DropChance = (Mathf.Sin ((BallLimit * 1.0f) / (ballLimitMax * 1.0f) * 3.14f));
			Debug.Log (DropChance);
			if (Random.Range (0.0f, 1.0f) < DropChance) {
				BallLimit--;
				float xLoc = Random.Range (transform.position.x - (XSpread / 2), transform.position.x + (XSpread / 2));
				Instantiate (DroppedObject, new Vector3 (xLoc, transform.position.y, 0), Quaternion.identity);
			}
		}
	}
}
