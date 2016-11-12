using UnityEngine;
using System.Collections;

public class Elavator : MonoBehaviour {

	public GameObject CounterWeight;
	public float FallDistance;
	public float SpeedDown;
	public float SpeedUp;

	private bool depressed = false;
	
	// Update is called once per frame
	void FixedUpdate () {
		if(!depressed && transform.localPosition.y < 0) {
			Change(-(SpeedUp * Time.fixedDeltaTime));
		}
		else if(depressed && transform.localPosition.y > -FallDistance) {
			Change(SpeedDown * Time.fixedDeltaTime);
		}
	}

	void Change(float value) {
		CounterWeight.transform.Translate(0, value, 0);
		transform.Translate(0, -value, 0);
	}

	void OnTriggerEnter2D() {
		depressed = true;
	}

	void OnTriggerExit2D() {
		depressed = false;
	}

}
