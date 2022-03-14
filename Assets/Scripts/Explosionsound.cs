using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosionsound : MonoBehaviour
{
    public AudioSource explosion;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 1)
        {
            explosion.Play();
        }
    }
}
