using UnityEngine;
using System.Collections;

public class DamageDealer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target) {
		target.SendMessage("Damage");
	}
}
