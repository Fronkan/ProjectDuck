using UnityEngine;
using System.Collections;

public class healthSystem : MonoBehaviour {

    public int health = 10;
    public int dmgModifier = 0;

    public void Damage() {
        Debug.Log(gameObject.name + ": DAMAGE TAKEN");

    }
}
