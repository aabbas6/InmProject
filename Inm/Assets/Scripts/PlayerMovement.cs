using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float movementSpeed;
    private float currentMovementSpeed;
    private float diagonalMoveMod;
    private bool isMoving;
    private Vector2 lastMove;
    private Vector2 diagonalMove;

    private float attackTimer;
    private float attackCD = .3f;
    private bool isAttacking = false;

    private Rigidbody2D pRB;
    private Animator anim;
   
    
	// Use this for initialization
	void Start ()
    {
        movementSpeed = GetComponent<Stats>().getMS();
        diagonalMoveMod = GetComponent<Stats>().getDMM();
        anim = GetComponent<Animator>();
        pRB = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        isMoving = false;
        if (!isAttacking)
        {
            float horizontalMovement = Input.GetAxis("Horizontal");
            float verticalMovement = Input.GetAxis("Vertical");
            
            if (horizontalMovement > 0.5f || horizontalMovement < -0.5f)
            {
                //transform.Translate(new Vector3(horizontalMovement * movementSpeed * Time.deltaTime, 0f, 0f));
                pRB.velocity = new Vector2(currentMovementSpeed * horizontalMovement, pRB.velocity.y);
                isMoving = true;
                lastMove = new Vector2(horizontalMovement, verticalMovement);

            }
            if (verticalMovement > 0.5f || verticalMovement < -.5f)
            {
                //transform.Translate(new Vector3(0f, verticalMovement * movementSpeed * Time.deltaTime, 0f));
                pRB.velocity = new Vector2(pRB.velocity.x, currentMovementSpeed * verticalMovement);
                isMoving = true;
                lastMove = new Vector2(horizontalMovement, verticalMovement);
            }
            if (horizontalMovement < .5f && horizontalMovement > -.5f)
            {
                pRB.velocity = new Vector2(0f, pRB.velocity.y);
            }

            if (verticalMovement < .5f && verticalMovement > -.5f)
            {
                pRB.velocity = new Vector2(pRB.velocity.x, 0f);
            }

            //if(Input.GetButtonDown("J"))
            //{
              //  isAttacking = true;
              //  attackTimer = attackCD;
               // anim.SetBool("");
            //}

            if(Mathf.Abs( horizontalMovement) > 0.5f && Mathf.Abs(verticalMovement) > 0.5f )
            {
                currentMovementSpeed = movementSpeed * diagonalMoveMod;
            }
            else
            {
                currentMovementSpeed = movementSpeed;
            }

            anim.SetFloat("moveX", horizontalMovement);
            anim.SetFloat("moveY", verticalMovement);
            anim.SetBool("isMoving", isMoving);
            anim.SetFloat("lastX", lastMove.x);
            anim.SetFloat("lastY", lastMove.y);
        }
        else
        {
            attackTimer -= Time.deltaTime;
            if(attackTimer <= 0f)
            {
                isAttacking = false;
            }

        }
	}
}
