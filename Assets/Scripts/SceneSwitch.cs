using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string targetSceneName; // Name of the scene you want to switch to.
    public float delayInSeconds = 2.0f; // The time delay in seconds before switching scenes.

    private float timer = 0.0f;
    private bool switchScene = false;

    void Update()
    {
        // Increment the timer.
        timer += Time.deltaTime;

        // Check if the timer has reached the specified delay.
        if (timer >= delayInSeconds && !switchScene)
        {
            // Load the target scene.
            SceneManager.LoadScene(targetSceneName);
            switchScene = true; // Ensure that we only load the scene once.
        }
    }
}
