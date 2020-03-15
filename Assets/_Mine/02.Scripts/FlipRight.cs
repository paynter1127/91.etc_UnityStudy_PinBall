using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipRight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, 100f * Time.deltaTime);
        }

	}
}
