using UnityEngine;
using System.Collections;

public class VictoryPoint : MonoBehaviour {
    public bool isVictory = false;

    void OnTriggerStay2D(Collider2D collider) {
        isVictory = collider.CompareTag("Player");
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        isVictory = false;
    }
}
