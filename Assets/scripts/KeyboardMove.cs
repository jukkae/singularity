using UnityEngine;
using System.Collections;

public class KeyboardMove : MonoBehaviour {

	public float speed = 5.0f;
	void Start () {
	
	}

	void Update () {
		Vector3 move = new Vector3 ();
		if(Input.GetKey(KeyCode.UpArrow)) {
			move = transform.forward;
		}
		if(Input.GetKey(KeyCode.DownArrow)) {
			move = -transform.forward;
		}
		if(Input.GetKey(KeyCode.RightArrow)) {
			move = transform.right;
		}
		if(Input.GetKey(KeyCode.LeftArrow)) {
			move = -transform.right;
		}
		transform.position += move * speed * Time.deltaTime;
	}
}
