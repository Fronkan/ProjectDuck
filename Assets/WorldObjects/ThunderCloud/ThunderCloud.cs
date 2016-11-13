using UnityEngine;
using System.Collections;

public class ThunderCloud : MonoBehaviour {

	public float delay;
	public float repeatTime;

	private SpriteRenderer renderer;

	void Start () {
		renderer = gameObject.GetComponent<SpriteRenderer>();

		InvokeRepeating("ReadyShoot", delay, repeatTime);
	}

	void ReadyShoot() {
		renderer.color = Color.grey;

		StartCoroutine(Shoot());
	}

	IEnumerator Shoot() {
		yield return new WaitForSeconds(1);

		renderer.color = Color.white;

		gameObject.SendMessage("RecieveSignal");
	}
}
