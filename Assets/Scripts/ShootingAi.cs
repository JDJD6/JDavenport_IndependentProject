using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAi : MonoBehaviour
{
    public float health = 50f;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0) Destroy(gameObject);
    }
}
