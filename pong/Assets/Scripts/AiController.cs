using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour {
	public float speed = 0.4f;
	public bool left = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (left) {
			if (this.transform.position.x >= 6.3f) {
				left = false;
			} else {
				this.transform.position += new Vector3 (speed, 0f, 0f);
			}
		} else {
			if (this.transform.position.x <= -6.300f) {
				left = true;
			}else {
				this.transform.position -= new Vector3 (speed, 0f, 0f);
			}
		}
	}
}
