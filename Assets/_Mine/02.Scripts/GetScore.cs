using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour {


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            ScoreMgr.instance.score += 200;
            collision.rigidbody.velocity += collision.rigidbody.velocity;
        }
    }
}
