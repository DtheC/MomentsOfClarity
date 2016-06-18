using UnityEngine;
using System.Collections;

public class ChainOrganiser : MonoBehaviour {

	public float Spring = 10;
	public float Damper = 0;
	public float TargetPosition = 1;

	public GameObject parent;

	// Use this for initialization
	void Start () {
		HingeJoint[] joints;
		joints = parent.GetComponentsInChildren<HingeJoint> ();
		Rigidbody[] bodies;
		bodies = parent.GetComponentsInChildren<Rigidbody> ();

		foreach (HingeJoint j in joints) {

			j.useSpring = false;
			j.useLimits = true;

//			JointSpring n = new JointSpring();
//			n.spring = Spring;
//			n.damper = Damper;
//			n.targetPosition = TargetPosition;
//			j.spring = n;

//			j.spring.spring = Spring;
//			j.spring.damper = Damper;
//			j.spring.targetPosition = TargetPosition;
		}

		foreach (Rigidbody r in bodies) {
			//r.useGravity = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
