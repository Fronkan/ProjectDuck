using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {

    public ParticleSystem deathParticles;

    void Start() {
       
    }

    void Damage() {
        Kill();
        GameObject.Find("_GM").SendMessage("ShowLoss");
        Destroy(gameObject);
    }
    void Kill()
    {
        ParticleSystem explosion = Object.Instantiate(deathParticles);
        explosion.transform.position = transform.position;

    }

}
