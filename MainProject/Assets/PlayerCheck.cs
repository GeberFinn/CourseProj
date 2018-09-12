using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheck : MonoBehaviour {

    public GameObject Room;
    bool b;
    Vector3 interval = new Vector3(0, 5,0);

    // Use this for initialization
    void Start () {
        b = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if ((collision.tag == "Player") && (b == true))
        {
            Instantiate(Room, this.transform.position + interval, Quaternion.identity);
            b = false;
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (b == false)
    //    {
    //        Instantiate(Room, RoomPos, Quaternion.identity);
    //        b = true;
    //    }

    //}
}
