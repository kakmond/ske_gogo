using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    private Rigidbody2D body;
    private float movementSpeed = 2;
    private float horizontal;
    private bool faceRight = true;
    private Animator animator;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        horizontal = Input.GetAxis("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(horizontal));
        if (!faceRight && horizontal>0 || horizontal<0 && faceRight)
        {
            faceRight = !faceRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        body.velocity = new Vector2(horizontal * movementSpeed, body.velocity.y);
    }
}
