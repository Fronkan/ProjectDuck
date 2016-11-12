using UnityEngine;
using System.Collections;

public class duckController : MonoBehaviour {

    public float speed = 0.2f;
    public float flySpeed= 0.2f;
    private bool faceingRight = true;
    private Rigidbody2D duckBody;

	// Use this for initialization
	void Start () {
        duckBody= gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
       float move = Input.GetAxis("Horizontal");
        
       
        if (move < 0 && faceingRight) {
            Flip();
        }

        else if (move > 0 && !faceingRight) {
            Flip();
        }


        float fly = Input.GetAxis("Vertical");
           //Currently only moves characters up, no physics to move it down
            duckBody.velocity = new Vector2(move * speed,fly * flySpeed);
           
    }

    void Flip() {
        faceingRight = !faceingRight;
        Vector3 scale = transform.localScale;
        scale.x = -1*scale.x;
        transform.localScale = scale;
    }
}
