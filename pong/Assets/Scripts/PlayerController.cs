using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public OSC osc;
	public float speed = 0.8f;


	// Use this for initialization
	void Start () {
		osc.SetAddressHandler("/wek/outputs", OnReceive);
	}

	void Update(){
		//move
	}

	void OnReceive(OscMessage message){
		Debug.Log ("On Receive");

		float x = message.GetFloat(0);
		float y = message.GetFloat (1);
		//float z = message.GetFloat (2);


		switch (Mathf.RoundToInt(x)) {
		case 1: 
			Debug.Log ("No Movement");
			break;
		case 3:
			Debug.Log ("Move Right");
			transform.position += new Vector3( speed,0f,0f);
			break;

		case 2:
			Debug.Log ("Move Left");
			transform.position -= new Vector3( speed,0f,0f);
			break;

		default:
			print ("Unrocognisable value");
			break;
		}
		//this.transform.position = b.center;
			
	}

}
