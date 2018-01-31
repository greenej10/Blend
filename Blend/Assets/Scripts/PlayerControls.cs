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
    float crouch=1;

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
            animator.SetBool("Is Sprinting", true);
            movement = new Vector2(hAxis, vAxis)* crouch * speed * Time.deltaTime * 3;            
        }
        else
        {
            animator.SetBool("Is Sprinting", false);
            movement = new Vector2(hAxis, vAxis) * speed *  crouch * Time.deltaTime;
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

        if (Input.GetKey(KeyCode.C))
        {
            animator.SetBool("Is Kneeling", true);
            crouch = 0;
        }

        else
        {
            animator.SetBool("Is Kneeling", false);
            crouch = 1;
        }

    }

    public bool facingRight = true; //Depends on if your animation is by default facing right or left

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
