using UnityEngine;

public class ShowHideControls : MonoBehaviour
{
    public GameObject controlsUI; // Reference to your UI elements
    private bool isControlsVisible = false; // Track the visibility state

    private void Start()
    {
        // Initially, hide the UI elements
        controlsUI.SetActive(false);
    }

    private void Update()
    {
        // Check for the key press (e.g., 'H' key)
        if (Input.GetKeyDown(KeyCode.H))
        {
            // Toggle the visibility of UI elements
            isControlsVisible = !isControlsVisible;
            controlsUI.SetActive(isControlsVisible);
        }
    }
}
