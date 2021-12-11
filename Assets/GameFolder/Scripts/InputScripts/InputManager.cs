using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    private PlayerControls playerControls;
    // Start is called before the first frame update
    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    private void Start()
    {
        playerControls.TouchInput.Touch.started += ctx => StartTouch(ctx);
        playerControls.TouchInput.Touch.canceled += ctx => EndTouch(ctx);
            
    }

    private void StartTouch(InputAction.CallbackContext context)
    {
        Debug.Log("Touch Started");
    }private void EndTouch(InputAction.CallbackContext context)
    {
        Debug.Log("Touch Ended");

    }
}
