using UnityEngine;
using System.Collections;

public class duckController : MonoBehaviour {

    public float speed = 0.2f;
    private bool faceingRight = true;
    private CharacterController characterController;

	// Use this for initialization
	void Start () {
        characterController = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
       float move = Input.GetAxis("Horizontal");
        gameObject.GetComponent<CharacterController>().Move(new Vector3(move*speed, 0, 0));
       
        if (move < 0 && faceingRight) {
            Flip();
        }

        else if (move > 0 && !faceingRight) {
            Flip();
        }
        
    }

    void Flip() {
        faceingRight = !faceingRight;
        Vector3 scale = transform.localScale;
        scale.x = -1*scale.x;
        transform.localScale = scale;
    }
}
