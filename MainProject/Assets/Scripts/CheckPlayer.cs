using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayer : MonoBehaviour {

    // Use this for initialization
    public RoomManager p;
    public int nRoom;



    void Start () {
        p = p.GetComponent<RoomManager>();
	}

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            p.curRoom = nRoom;
            p.nextRoom = true;
        }
    }
}
