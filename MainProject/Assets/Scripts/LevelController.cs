using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    public Transform parentObject;
    public GameObject platformPrefab ;
    public GameObject platformDangPrefab;

    bool bad = false;
    public int numberOfPlatform;
    public float levelWidth = 2f;
    public float minY = .2f;
    public float maxY = 1.5f;
    public int probability = 50;

    //public int numberOfDangPlatform;
    //public float DangMinY =10f;
   // public float DangMaxY =15f;



    // Use this for initialization
    void Start () {

        Generate();
        

    }

    void Generate() {
        Vector3 spawnPosition = new Vector3();
        //Vector3 spawnDangPosition = new Vector3();

        for (int i = 0; i < numberOfPlatform; i++)
        {
            int proc = Random.Range(1, 100);

            if (proc > probability || bad == true)
            {
                float height = gameObject.transform.position.y + Random.Range(minY, maxY);
                spawnPosition.y += height;
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                GameObject myPrefabClone = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
                myPrefabClone.transform.parent = parentObject;
                bad = false;
            }
            else
            {
                spawnPosition.y += Random.Range(minY, maxY);
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                GameObject myPrefabClone = Instantiate(platformDangPrefab, spawnPosition, Quaternion.identity) as GameObject;
                myPrefabClone.transform.parent = parentObject;
                bad = true;
            }
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
