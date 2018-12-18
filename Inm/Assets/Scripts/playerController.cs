using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private float movementSpeed;
	// Use this for initialization
	void Start ()
    {
        movementSpeed = GetComponent<Stats>().getMS();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        if(horizontalMovement > 0.5f || horizontalMovement < -0.5f)
        {
            transform.Translate(new Vector3(horizontalMovement * movementSpeed * Time.deltaTime, 0f, 0f));
        }
        if(verticalMovement > 0.5 || verticalMovement < -0.5f)
        {
            transform.Translate(new Vector3(0f, verticalMovement * movementSpeed * Time.deltaTime, 0f));
        }


	}
}
