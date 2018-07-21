using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Dang : MonoBehaviour {

    public GameObject PlayerObj;

    private Player player;

    private void Start()
    {
        player = PlayerObj.GetComponent<Player>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        player.movementSpeed = 0;
    }
}
