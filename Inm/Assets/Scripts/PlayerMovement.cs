using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float movementSpeed;

    private Animator anim;
    private bool isMoving;
    private Vector2 lastMove;

	// Use this for initialization
	void Start ()
    {
        movementSpeed = GetComponent<Stats>().getMS();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        isMoving = false;

        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
		if(horizontalMovement > 0.5f || horizontalMovement < -0.5f)
        {
            transform.Translate(new Vector3(horizontalMovement * movementSpeed * Time.deltaTime, 0f, 0f));
            isMoving = true;
            lastMove = new Vector2(horizontalMovement,0f);
        }
        if(verticalMovement > 0.5f || verticalMovement < -.5f)
        {
            transform.Translate(new Vector3(0f, verticalMovement * movementSpeed * Time.deltaTime, 0f));
            isMoving = true;
            lastMove = new Vector2(0f, verticalMovement);
        }

        anim.SetFloat("moveX", horizontalMovement);
        anim.SetFloat("moveY", verticalMovement);
        anim.SetBool("isMoving", isMoving);
        anim.SetFloat("lastX", lastMove.x);
        anim.SetFloat("lastY", lastMove.y);
	}
}
