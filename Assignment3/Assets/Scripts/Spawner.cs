using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;
    public AudioSource audioData;
    private bool isPaused = false;

    
    void Update()
    {

        
        if (Input.GetButtonDown("Jump"))
        {
            SpawnPin();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Time.timeScale = 1;
                isPaused = false;
            } else if (!isPaused)
                {
                    Time.timeScale = 0;
                    isPaused = true;
                }

            
        }
    }

    void SpawnPin ()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
        audioData.Play(0);
    }
}
