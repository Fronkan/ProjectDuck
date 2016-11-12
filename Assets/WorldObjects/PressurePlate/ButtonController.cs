using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public SignalReciever signalReciever;

	void OnTriggerEnter() {
		Raise();
	}

	void OnMouseDown() {
		Raise();
	}

	void Raise() {
		signalReciever.SendMessage("RecieveSignal");
	}
}
