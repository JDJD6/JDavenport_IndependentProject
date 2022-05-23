using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RESTART : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        GameObject.Find("Spawn Manager").GetComponent<SpawnManager>().enabled = true;

        GameObject.Find("FPSController").GetComponent<FPSShooter>().enabled = true;

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
