using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject impactVFX;
    public AudioClip shoot;
    public AudioClip explosion;
    
    private bool collided;

    private void Start()
    {
        AudioSource.PlayClipAtPoint(shoot, transform.position);
    }
    void OnCollisionEnter (Collision co)
    {
        if(co.gameObject.tag != "Bullet" && co.gameObject.tag != "Player" && !collided)
        {
            collided = true;

            var impact = Instantiate(impactVFX, co.contacts[0].point, Quaternion.identity) as GameObject;

            Destroy(impact, 2);

            Destroy(gameObject);

            AudioSource.PlayClipAtPoint(explosion, transform.position);
        }
    }
}
