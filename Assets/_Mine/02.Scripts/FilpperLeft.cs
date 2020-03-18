using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilpperLeft : MonoBehaviour {

    HingeJoint hinge;

    private void Awake()
    {
        Physics.IgnoreLayerCollision(8, 9, true);
        Physics.IgnoreLayerCollision(10, 9, true);
        Physics.IgnoreLayerCollision(11, 9, true);
        Physics.IgnoreLayerCollision(12, 9, true);
        Physics.IgnoreLayerCollision(13, 9, true);
        Physics.IgnoreLayerCollision(0, 9, true);
        hinge = GetComponent<HingeJoint>();
    }

    private void Update()
    {
        var hingeSpring = hinge.spring;
        hingeSpring.spring = 2f;
        hinge.spring = hingeSpring;


        if (Input.GetKey(KeyCode.A))
        {
            var motor = hinge.motor;
            hinge.motor = motor;
            hinge.useMotor = true;
        }
        else
        {
            var motor = hinge.motor;
            hinge.motor = motor;
            hinge.useMotor = false;
        }
    }

}
