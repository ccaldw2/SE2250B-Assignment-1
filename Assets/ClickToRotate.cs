using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseDown () {
        transform.eulerAngles += new Vector3(0, 0, 10);
	}
}
