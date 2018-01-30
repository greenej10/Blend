using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    public float speed;
    private Rigidbody2D rig;
    public bool sprint=false;
    public bool isMoving = false;
    Vector2 position;
    public Animator animator;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()

    {
        
        //directional movement based on input axis values.
        float hAxis = Input.GetAxis("Horizontal");
        //Debug.Log(hAxis);
        float vAxis = Input.GetAxis("Vertical");
        //Debug.Log(vAxis);

       
        

        Vector2 movement;

        

        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprint = true;
            movement = new Vector2(hAxis, vAxis) * speed * Time.deltaTime * 3;            
        }
        else
        {
            sprint = false;
            movement = new Vector2(hAxis, vAxis) * speed * Time.deltaTime;
        }

        if (!rig.position.Equals(rig.position + movement))
        {
            isMoving = true;
            animator.SetBool("Is Moving", isMoving);
        }
        else
        {
            isMoving = false;
            animator.SetBool("Is Moving", isMoving);
        }

        rig.MovePosition(rig.position + movement);

        if (Input.GetKey(KeyCode.X))
        {
            animator.SetBool("Is Shooting", true);
        }

        else
        {
            animator.SetBool("Is Shooting", false);
        }
        
    }
}
