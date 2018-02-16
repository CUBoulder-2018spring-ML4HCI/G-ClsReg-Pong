//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class ReceiveData : MonoBehaviour {
//
//	public OSC osc;
//
//	// Use this for initialization
//	void Start () {
//		osc.SetAddressHandler("/wek/outputs", OnReceive );
//
//	}
//
//	void OnReceive(OscMessage message){
//		float x = message.GetFloat (0);
//		float y = message.GetFloat (1);
//		float z = message.GetFloat (2);
//
//		if (x >= .7) {
//			Debug.Log ("Move Left");
//		} else if (x <= .3) {
//			Debug.Log ("MOve Right");
//		} else {
//			Debug.Log ("Stay");
//		}
//
//		GameObject puck = GameObject.Find ("Puck");
//		//puck.GetComponent<PuckController> ().force = z;
//
//		//Debug.Log (" X: " + x.ToString () + " Y: " + y.ToString () + " Z: " + z.ToString ());
//	}
//
//}
	
