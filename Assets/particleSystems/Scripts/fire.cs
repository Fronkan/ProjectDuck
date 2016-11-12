using UnityEngine;
using System.Collections;


public class fire : MonoBehaviour {
    public GameObject button;
    private ParticleSystem dispensor;
	// Use this for initialization
	void Start () {
        dispensor = GetComponent<ParticleSystem>();
        dispensor.Pause();
	}

    // Update is called once per frame
    void Update()
    {
        if (button.GetComponent<trigger>().fire)
        {
            if (!dispensor.isPlaying){
                dispensor.Play();
            }
            Debug.Log("START");
        }
        else
        {
            if (dispensor.isPlaying){ dispensor.Stop(); }
            Debug.Log("STOP");
        }
    }
}