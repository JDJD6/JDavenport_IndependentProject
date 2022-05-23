using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    private void OnCollisionEnter(Collision collision)
    {
        gameOverText.gameObject.SetActive(true);

        restartButton.gameObject.SetActive(true);

        GameObject.Find("Spawn Manager").GetComponent<SpawnManager>().enabled = false;

        GameObject.Find("FPSController").GetComponent<FPSShooter>().enabled = false;

        Time.timeScale = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
