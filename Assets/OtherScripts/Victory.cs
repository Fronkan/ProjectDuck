using UnityEngine;
using System.Collections;

public class Victory : MonoBehaviour {
    private VictoryPoint point1;
    private VictoryPoint point2;

	// Use this for initialization
	void Start () {
        point1 = transform.GetChild(0).GetComponent<VictoryPoint>();
        point2 = transform.GetChild(1).GetComponent<VictoryPoint>();
    }
	
	// Update is called once per frame
	void Update () {
        if (point1.isVictory && point2.isVictory) {
            Debug.Log("VICTORY");
            GameObject.Find("_GM").SendMessage("ShowWin");

        }
	}
}
