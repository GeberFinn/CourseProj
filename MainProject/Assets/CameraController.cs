using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    public Transform target;
    public float smoothSpeed = .3f;
    Vector3 position;




    void LateUpdate () {
	    if (target.position.y > transform.position.y)
        {
            position.x = transform.position.x;
            position.z = - 10f;
            position.y = target.position.y;
            transform.position = Vector3.Lerp(transform.position, position,smoothSpeed*Time.deltaTime );
             
        }	
	}
}
