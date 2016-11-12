using UnityEngine;
using System.Collections;

public class GateRaiser : SignalReciever {

	public float TargetHeight;
	public bool AutoLower;
	public float RaiseSpeed;
	public float LowerSpeed;

	private enum State {
		still, raising, lowering
	};

	private State state = State.still;

	void Update() {
		Debug.Log(state);
		switch(state) {
			case State.raising:
				gameObject.transform.position += Vector3.up * RaiseSpeed * Time.deltaTime;
				if(gameObject.transform.position.y > TargetHeight) {
					state = State.lowering;
				}
				break;
			case State.lowering:
				gameObject.transform.position += Vector3.down * LowerSpeed * Time.deltaTime;
				if(gameObject.transform.position.y < Vector3.zero.magnitude) {
					state = State.still;
				}
				break;
		}
	}

	void RecieveSignal() {
		Debug.Log("Raisinig");
		state = State.raising;
	}
}
