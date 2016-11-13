using UnityEngine;
using System.Collections;

public class DuckWater : MonoBehaviour {
	
	void OnTriggerStay2D(Collider2D target) {
		if(target.name == "duck") {
			Vector2 pos = target.gameObject.transform.position;
			//target.gameObject.transform.position
			//	= new Vector2(pos.x, transform.position.y + 1f);
			
			target.gameObject.transform.Translate(0f, 0.2f, 0f);
		}
	}
}
