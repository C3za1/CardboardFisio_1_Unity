using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    public string sceneName="upam1";
    public const float TIME_LIMIT = 405F;
    private float timer = 0F;
    // Use this for initialization
    void Update()
    {
        // deltaTime is the time (measured in seconds) since the previous Update step
        // it's typically very small, e.g. 1/60th of a second ~= 0.0167F
        this.timer += Time.deltaTime;

        // check if it's time to switch scenes
        if (this.timer >= TIME_LIMIT)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}