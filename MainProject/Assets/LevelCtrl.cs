using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCtrl : MonoBehaviour {

    Vector2 startpos = new Vector2(0, 1);
    public GameObject StartPlatform;
	// Use this for initialization
	void Start () {
        Instantiate(StartPlatform, startpos, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
