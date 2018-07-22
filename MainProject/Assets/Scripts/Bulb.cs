using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulb : MonoBehaviour {

    private float constIntens = 5.0f;
    private float intens;
    private float TimeDown;


	void Start () {
        TimeDown = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.GetComponent<Light>().intensity != constIntens) gameObject.GetComponent<Light>().intensity = constIntens;

        if (TimeDown > 0) TimeDown -= Time.deltaTime;
        if (TimeDown < 0) TimeDown = 0;
        if (TimeDown == 0)
        {
            intens = Random.Range(3.0f, 6.0f);
            gameObject.GetComponent<Light>().intensity = intens;
            TimeDown = Random.Range(1f, 2f);
        }
    }
}
