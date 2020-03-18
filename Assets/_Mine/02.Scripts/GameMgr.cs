using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour {

    public GameObject ballPref;
    public Transform spawnPos;

    bool isPlay = false;

	// Use this for initialization
	void Start () {
        resetPos();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && !isPlay)
        {
            isPlay = true;
            ballPref.GetComponent<Rigidbody>().AddForce(spawnPos.forward * 0.2f, ForceMode.Impulse);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            resetPos();
        }
    }

    void resetPos()
    {
        ballPref.transform.position = spawnPos.position;
        isPlay = false;
    }

}
