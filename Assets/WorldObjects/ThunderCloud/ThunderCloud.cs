using UnityEngine;
using System.Collections;

public class ThunderCloud : MonoBehaviour {

	SpriteRenderer cloud;
	SpriteRenderer thunderCloud;
	public float delay;
	public float repeatTime;

	// Use this for initialization
	void Start () {
		cloud = transform.Find("cloud").GetComponent<SpriteRenderer>();
		thunderCloud = transform.Find("thunderCloud").GetComponent<SpriteRenderer>();

		InvokeRepeating("ReadyShoot", delay, repeatTime);
	}
	
	// Update is called once per frame
	void Update () { }

	void ReadyShoot() {
		cloud.enabled = false;
		thunderCloud.enabled = true;

		StartCoroutine(Shoot());
	}

	IEnumerator Shoot() {
		yield return new WaitForSeconds(1);
		gameObject.SendMessage("RecieveSignal");
		cloud.enabled = true;
		thunderCloud.enabled = false;
	}
}
