using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckController : MonoBehaviour {
	public OSC osc;
	private Rigidbody ri;
	public Vector3 initialImpulse;
	public float boost = 1;

	// Use this for initialization
	void Start () {
		osc.SetAddressHandler("/wek/puck", OnReceivePuck);
		ri = this.GetComponent<Rigidbody>();
		//ri.AddForce(initialImpulse, ForceMode.Impulse);
	}

	// Update is called once per frame
	void Update () {
		ri.AddForce(transform.forward * boost,  ForceMode.Impulse);
	}

	void OnReceivePuck(OscMessage message){
		Debug.Log("Puck Received");
		boost = message.GetFloat(0);
	}

}
