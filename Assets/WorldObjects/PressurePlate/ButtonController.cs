using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public SignalReciever signalReciever;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter() {
		Debug.Log("Trigger");
		signalReciever.SendMessage("RecieveSignal");
	}

	void OnMouseDown() {
		Debug.Log("Sending raise");
		signalReciever.SendMessage("RecieveSignal");
	}
}
