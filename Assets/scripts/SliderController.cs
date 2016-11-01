using UnityEngine;
using System.Collections;

public class SliderController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MovePlatforms () {
		foreach(Transform child in transform) {
			if (Mathf.Abs (child.position.x) < 15) {
				float newX = child.position.x * 5;
				child.position = new Vector3 (newX, child.position.y, child.position.z);
			}
		}
	}
}
