using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour {

    public GameObject DangPlatform;
    public GameObject PlatForm;
    public GameObject Checker;

    [Range(0,10)]
    public int Complexity;
    bool DangNext;
    public int NumberOfPlat;
	// Use this for initialization
	void Start () {
        DangNext = false; 
        Generate();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Generate()
    {

        Vector3 curPos = new Vector3(0, 0, 0); 
        Vector3 startPos = new Vector3(0, 0, 0);
        Vector3 checkPos = new Vector3(0, 0, 0);
        for (int i = 0; i < NumberOfPlat; i++)
        {


            startPos.y += curPos.y;
            startPos.x = curPos.x;
            curPos = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(0.5f, 2.0f), 0f);

            
            if ((Random.Range(1, 10) > Complexity) || (DangNext == false) )
            { 
                Instantiate(PlatForm, this.transform.position + startPos, Quaternion.identity);
                DangNext = true;
            }
            else
            {
                Instantiate(DangPlatform, this.transform.position + startPos, Quaternion.identity);
                DangNext = false;
            }
        }
        checkPos.y = startPos.y + -5;

        Instantiate(Checker, this.transform.position + checkPos, Quaternion.identity);
    }


}
