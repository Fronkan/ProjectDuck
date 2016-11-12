using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {
    public bool fire = false;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            fire = true;
        }

    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            fire = false;
        }
    }

}
