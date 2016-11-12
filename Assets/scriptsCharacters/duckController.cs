using UnityEngine;
using System.Collections;

public class duckController : MonoBehaviour {

    public float speed = 0.2f;
    public float flySpeed= 0.2f;
    private bool faceingRight = true;
    private CharacterController characterController;

	// Use this for initialization
	void Start () {
        characterController = gameObject.GetComponent<CharacterController>();
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
            characterController.Move(new Vector3(move * speed,fly * flySpeed, 0));
           
    }

    void Flip() {
        faceingRight = !faceingRight;
        Vector3 scale = transform.localScale;
        scale.x = -1*scale.x;
        transform.localScale = scale;
    }
}
