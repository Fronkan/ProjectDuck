using UnityEngine;
using System.Collections;

public class Grab : MonoBehaviour {

    public string grabButton = "Action1_P1";
    public GameObject target;
    private bool canGrab = false;
    private BoxCollider2D claw;

    void Start() {
        claw = gameObject.GetComponent<BoxCollider2D>();
    }

    void Update() {

        if (Input.GetButton(grabButton)) {
            Grabing();
        }
    }


    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Player")) {
            Debug.Log(canGrab);
            canGrab = true;
        }

    }

    void OnTriggerExit2D(Collider2D collider) {
        if (collider.CompareTag("Player")){
            Debug.Log(canGrab);
            canGrab = false;
        }
    }
    void Grabing() {
        if (canGrab) { 
            target.transform.position = transform.position;
        }

    }

}
