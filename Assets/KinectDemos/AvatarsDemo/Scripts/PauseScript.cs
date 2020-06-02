using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    public bool paused;

    // Start is called before the first frame update
    void Start()
    {
        paused = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (paused) {
                Time.timeScale = 0f;
            }
            else {
                Time.timeScale = 1f;
            }
            paused = !paused;
        }
    }
}
