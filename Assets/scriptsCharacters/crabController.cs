using UnityEngine;
using System.Collections;

public class crabController : MonoBehaviour {

    public float speed = 1f;
    public float jumpForce = 1f;
    public float gravity = 1f;

    private float move = 0f;

    private bool isGrounded;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    private Rigidbody2D crabBody;


    // Use this for initialization
    void Start () {
        crabBody = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        IsGrounded();
        Jump();
        Move();
       
	}



    void Move() {
        move = Input.GetAxis("Horizontal");

        crabBody.velocity = new Vector2(speed * move, crabBody.velocity.y);
    }
    void Jump() {
        bool isJumping = Input.GetButton("Jump");
        if (isGrounded && isJumping)
        {
            crabBody.AddForce(new Vector2(0, jumpForce));
        }

    }
   

    void IsGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        Debug.Log(isGrounded);
    }
}
