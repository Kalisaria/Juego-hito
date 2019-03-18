using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody2D rb;
	private Animator anim;
	public bool grounded;
    public float speed = 6f;
	public float jumpPower = 6f;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody2D>();
		anim = GetComponent <Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

		float horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

		 anim.SetBool("Grounded", grounded);
         anim.SetFloat("SpeedY", rb.velocity.y); 
		 anim.SetFloat("SpeedX",Mathf.Abs(rb.velocity.x));

		       
	 	if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (grounded == true)
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);

        }
			
		if (horizontal > 0.1f)
        {
            transform.localScale = new Vector3(7f, 7f, 7f);
        }

        if (horizontal < -0.1f)
        {
            transform.localScale = new Vector3(-7f, 7f, 7f);
        }

		
	}
}
