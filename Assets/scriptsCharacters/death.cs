using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {

    public ParticleSystem test;

    void Start() {
       
    }

    void Damage() {
        Kill();
        Destroy(gameObject);
    }
    void Kill()
    {
        ParticleSystem explosion = Object.Instantiate(test);
        explosion.transform.position = transform.position;

    }

}
