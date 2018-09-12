using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour {

    public GameObject Parent;
    public float minY = .2f;
    public float maxY = 1.5f;
    public GameObject platformPrefab;
    public GameObject platformDangPrefab;
    public GameObject[] platforms;
    public float levelWidth = 2f;
    int countPlatforms;
    float height;

    void Start () {

        
        countPlatforms = Random.Range(8, 10);
        platforms = new GameObject[countPlatforms];
        //platforms = Parent.GetComponentsInChildren<GameObject>();

        Generation();
    }

    void Generation()
    {
        Vector3 spawnPosition = new Vector3();
        //Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < platforms.Length; i++)
        {
            platforms[i] = platformPrefab;
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Vector2 p = new Vector2(spawnPosition.x, platforms[i].transform.localPosition.y + Random.Range(minY, maxY));
            platforms[i].transform.localPosition = p;
            Instantiate(platformPrefab, p, Quaternion.identity);
        }
    }


    void Update () {
		
	}
}
