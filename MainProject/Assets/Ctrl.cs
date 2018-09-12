using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl : MonoBehaviour
{

    public int NumberOfPlatform;

    public GameObject myPrefab;
    public Transform parentObject;
    private float YCheck;

    public Transform Check  ;
    public GameObject CheckPref;

    void Start()
    {
        Vector3 platpos = myPrefab.transform.position;
        for (int i = 0; i < NumberOfPlatform; i++)
        {
            Vector3 nextpos = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(0.8f, 1.5f), 0);
            platpos.x = nextpos.x;
            platpos.y += nextpos.y;

            GameObject myPrefabClone1 = Instantiate(myPrefab, platpos, myPrefab.transform.rotation) as GameObject;
            myPrefabClone1.transform.parent = parentObject;
            //YCheck = platpos.y;
        }

        Check = GetComponent<Transform>();
        GameObject myPrefabClone2 = Instantiate(CheckPref, Check.transform.position, myPrefab.transform.rotation) as GameObject;
        myPrefabClone2.transform.parent = parentObject;

        
    }


}