using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    public int curRoom;
    public bool nextRoom;

    public Transform r1, r2, r3;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		
	}

    void SelectNextRoom()
    {
        if (nextRoom)
        {
            switch (curRoom)
            {
                case 1:
                    r2.position = new Vector2(0, r1.position.y + 22);
                    r3.position = new Vector2(0, r2.position.y + 22);
                    break;
                case 2:
                    r3.position = new Vector2(0, r2.position.y + 22);
                    r1.position = new Vector2(0, r3.position.y + 22);
                    break;
                case 3:
                    r1.position = new Vector2(0, r3.position.y + 22);
                    r2.position = new Vector2(0, r1.position.y + 22);
                    break;
            }
        }
    }
}
