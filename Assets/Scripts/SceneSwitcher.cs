using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneSwitcher : MonoBehaviour 
{ 
    public string targetSceneName; // Name of the scene you want to switch to.
    
    // Function to switch to the target scene.
    public void SwitchToTargetScene()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}