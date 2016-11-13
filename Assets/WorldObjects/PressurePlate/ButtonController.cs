using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public SignalReciever signalReciever;
    public Sprite offSprite;
    public Sprite onSprite;
    private SpriteRenderer buttonRenderer;

    void Start() {
        buttonRenderer = GetComponent<SpriteRenderer>();
        buttonRenderer.sprite = offSprite;
    }

	void OnTriggerEnter2D() {
		Raise();
        buttonRenderer.sprite = onSprite;
	}

    void OnTriggerExit2D() {
        buttonRenderer.sprite = offSprite;
    }

	void OnMouseDown() {
		Raise();
	}

	void Raise() {
		signalReciever.SendMessage("RecieveSignal");
	}
}
