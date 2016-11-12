using UnityEngine;
using System.Collections;

public class GateRaiser : SignalReciever {

	public float TargetHeight;
	public float RaiseSpeed;
	public float LowerSpeed;

	private enum State {
		still, raising, lowering
	};

	private State state = State.still;

	void Update() {
		switch(state) {
			case State.raising:
				gameObject.transform.localPosition += Vector3.up
				                                    * RaiseSpeed
				                                    * Time.deltaTime;
				if(gameObject.transform.localPosition.y > TargetHeight) {
					state = State.lowering;
				}
				break;
			case State.lowering:
				gameObject.transform.localPosition += Vector3.down
				                                    * LowerSpeed
				                                    * Time.deltaTime;
				if(gameObject.transform.localPosition.y < 0) {
					gameObject.transform.localPosition = Vector3.zero;
					state = State.still;
				}
				break;
		}
	}

	void RecieveSignal() {
		state = State.raising;
	}
}
