//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/GameFolder/Scripts/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""TouchInput"",
            ""id"": ""9ba413b8-29df-4530-8beb-600e1052937b"",
            ""actions"": [
                {
                    ""name"": ""Touch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e25c24f7-7a36-4640-a352-1b266aec2d59"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchLocation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f5a1816b-5498-4a06-8882-73837f148d9f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""47382b0b-87b2-4bac-a86e-67e50bdb1b71"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84c3d8ed-c9d7-450b-bbdc-db5da14bd142"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchLocation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TouchInput
        m_TouchInput = asset.FindActionMap("TouchInput", throwIfNotFound: true);
        m_TouchInput_Touch = m_TouchInput.FindAction("Touch", throwIfNotFound: true);
        m_TouchInput_TouchLocation = m_TouchInput.FindAction("TouchLocation", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // TouchInput
    private readonly InputActionMap m_TouchInput;
    private ITouchInputActions m_TouchInputActionsCallbackInterface;
    private readonly InputAction m_TouchInput_Touch;
    private readonly InputAction m_TouchInput_TouchLocation;
    public struct TouchInputActions
    {
        private @PlayerControls m_Wrapper;
        public TouchInputActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Touch => m_Wrapper.m_TouchInput_Touch;
        public InputAction @TouchLocation => m_Wrapper.m_TouchInput_TouchLocation;
        public InputActionMap Get() { return m_Wrapper.m_TouchInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchInputActions set) { return set.Get(); }
        public void SetCallbacks(ITouchInputActions instance)
        {
            if (m_Wrapper.m_TouchInputActionsCallbackInterface != null)
            {
                @Touch.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouch;
                @Touch.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouch;
                @Touch.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouch;
                @TouchLocation.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchLocation;
                @TouchLocation.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchLocation;
                @TouchLocation.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnTouchLocation;
            }
            m_Wrapper.m_TouchInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Touch.started += instance.OnTouch;
                @Touch.performed += instance.OnTouch;
                @Touch.canceled += instance.OnTouch;
                @TouchLocation.started += instance.OnTouchLocation;
                @TouchLocation.performed += instance.OnTouchLocation;
                @TouchLocation.canceled += instance.OnTouchLocation;
            }
        }
    }
    public TouchInputActions @TouchInput => new TouchInputActions(this);
    public interface ITouchInputActions
    {
        void OnTouch(InputAction.CallbackContext context);
        void OnTouchLocation(InputAction.CallbackContext context);
    }
}
