using UnityEngine;
using System.Collections;

public class DuckWater : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D target) {
		if(target.name == "duck") {
			Vector2 pos = target.gameObject.transform.position;
			target.gameObject.transform.position
				= new Vector2(pos.x, transform.position.y + 5);
		}
	}
}
