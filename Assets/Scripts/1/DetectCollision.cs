using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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

            
        }
    }
}
