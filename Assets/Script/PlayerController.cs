using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    Rigidbody rbody;
    Animator anim;
    private bool isAttacking;
    //static bool playerExist;

    // Use this for initialization
    void Start () {
        rbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
	}
    void FixedUpdate()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        /*
        if (movement_vector != Vector2.zero)
        {
            anim.SetBool("isWalking", true);
            // set new direction
            anim.SetFloat("Input_x", movement_vector.x);
            anim.SetFloat("Input_y", movement_vector.y);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
        */
        //rbody.AddForce(movement_vector * Time.deltaTime * speed);
        rbody.AddForce(movement_vector * speed);
    }
}
