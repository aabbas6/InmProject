using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private float movementSpeed;

    private Rigidbody2D pRB;

    private bool isAttacking1;
    private float attackCD = .5f;
    private float attackTimer;

    
    
    // Use this for initialization
	void Start ()
    {
        movementSpeed = GetComponent<Stats>().getMS();
        pRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        //player movement up down left right
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        if(horizontalMovement > 0.5f || horizontalMovement < -0.5f)
        {
            //transform.Translate(new Vector3(horizontalMovement * movementSpeed * Time.deltaTime, 0f, 0f));
            pRB.velocity = new Vector2(horizontalMovement * movementSpeed, pRB.velocity.y);
        }
        if(verticalMovement > 0.5 || verticalMovement < -0.5f)
        {
            //transform.Translate(new Vector3(0f, verticalMovement * movementSpeed * Time.deltaTime, 0f));
            pRB.velocity = new Vector2(pRB.velocity.x, verticalMovement * movementSpeed);
        }
        if (horizontalMovement < .5f && horizontalMovement > -.5f)
        {
            pRB.velocity = new Vector2(0f, pRB.velocity.y);
        }

        if(verticalMovement <.5f && verticalMovement > -.5f)
        {
            pRB.velocity = new Vector2(pRB.velocity.x, 0f);
        }

        
        


	}
}
