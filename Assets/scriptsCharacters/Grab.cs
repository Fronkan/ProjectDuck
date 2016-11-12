using UnityEngine;
using System.Collections;

public class Grab : MonoBehaviour {
    private bool canGrab;
    public LayerMask grabable;
    public Transform clawPos;
    public GameObject crab;
    float grabRadius = 0.2f;

    Grab() {

        canGrab = Physics2D.OverlapCircle(clawPos.position, grabRadius,grabable);
        gameObject.AddComponent<FixedJoint2D>();
        FixedJoint2D claw = gameObject.GetComponent<FixedJoint2D>();
        if (canGrab) {
            claw.connectedBody = crab.GetComponent<Rigidbody2D>();
        }


    }

}
