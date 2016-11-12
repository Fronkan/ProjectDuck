using UnityEngine;
using System.Collections;

public class Dispenser : SignalReciever {

	public Vector2 DispenseSpeedDirection;
	public GameObject DispensedObject;
	public float BulletLifeTime;

	void Dispense() {
		GameObject clone = Object.Instantiate(DispensedObject);
		clone.transform.position = gameObject.transform.position;
		clone.GetComponent<Rigidbody2D>().velocity = DispenseSpeedDirection;

		Destroy(clone, BulletLifeTime);
	}

	void OnMouseDown() {
		Dispense();
	}

	void RecieveSignal() {
		Dispense();
	}
}
