using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour {


    private Player player;
    


	// Use this for initialization
	void Start () {

        player = GetComponentInParent<Player>();
	}

     void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Floor")
        {
            player.grounded = true;
        }
    }

	void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Floor")
        {
            player.grounded = false;
        }
	}
}