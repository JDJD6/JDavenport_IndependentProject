using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public bool gameOver = false;
    
    private void OnTriggerEnter(Collider other)
    {
        Score1.scoreValue += 50;
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Gameover"))
        {
            Debug.Log("Game Over!");
            gameOver = true;

            GameObject.Find("Spawn Manager").GetComponent<SpawnManager>().enabled = false;

            GameObject.Find("FPSController").GetComponent<FPSShooter>().enabled = false;

            Time.timeScale = 0;
        }
    }
}
