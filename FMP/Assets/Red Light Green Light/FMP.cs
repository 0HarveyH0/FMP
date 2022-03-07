// GENERATED AUTOMATICALLY FROM 'Assets/Red Light Green Light/FMP.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FMP : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FMP()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FMP"",
    ""maps"": [
        {
            ""name"": ""RLGL"",
            ""id"": ""925e9f8a-d1cb-4751-9e0c-33b9c851abc6"",
            ""actions"": [
                {
                    ""name"": ""MoveForward"",
                    ""type"": ""Value"",
                    ""id"": ""4f7c2c39-1a76-4b71-8645-31c02c4a70b5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Change Scene"",
                    ""type"": ""Button"",
                    ""id"": ""e53e2c20-2b20-4abb-bf73-86dea56caae8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""bc810333-22b6-450a-8dd5-aba553e193f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ac652171-6221-48fe-86a0-0efdb7b8c3d3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8ad2a125-5e82-40b7-bb0d-c4da84e22312"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c1efd5a0-cf45-4fe7-be65-125d7003fb61"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1671ef56-5ff7-4ad0-9095-c18986baabf6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""259500eb-1241-4981-9379-6cbf147b4fe9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f1bc1564-9302-4daa-93e0-59d715d00227"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""50ad5453-0b33-40c6-9cc0-8bc2e4db8b78"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7ea03cf8-8846-4927-bd7d-20505d24cd94"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c083bfde-0469-43ff-b7ba-e1464dfa7234"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""352b9ca7-cbbf-491d-bd3e-9c8d368d79ad"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6c4f9f05-8591-4931-b361-3063c5cdd351"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Scene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""444e8e9f-5589-48b8-a839-8afff5a69e7a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdb53073-145f-4fe8-8c28-3d3dd1313ba3"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // RLGL
        m_RLGL = asset.FindActionMap("RLGL", throwIfNotFound: true);
        m_RLGL_MoveForward = m_RLGL.FindAction("MoveForward", throwIfNotFound: true);
        m_RLGL_ChangeScene = m_RLGL.FindAction("Change Scene", throwIfNotFound: true);
        m_RLGL_Select = m_RLGL.FindAction("Select", throwIfNotFound: true);
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

    // RLGL
    private readonly InputActionMap m_RLGL;
    private IRLGLActions m_RLGLActionsCallbackInterface;
    private readonly InputAction m_RLGL_MoveForward;
    private readonly InputAction m_RLGL_ChangeScene;
    private readonly InputAction m_RLGL_Select;
    public struct RLGLActions
    {
        private @FMP m_Wrapper;
        public RLGLActions(@FMP wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveForward => m_Wrapper.m_RLGL_MoveForward;
        public InputAction @ChangeScene => m_Wrapper.m_RLGL_ChangeScene;
        public InputAction @Select => m_Wrapper.m_RLGL_Select;
        public InputActionMap Get() { return m_Wrapper.m_RLGL; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RLGLActions set) { return set.Get(); }
        public void SetCallbacks(IRLGLActions instance)
        {
            if (m_Wrapper.m_RLGLActionsCallbackInterface != null)
            {
                @MoveForward.started -= m_Wrapper.m_RLGLActionsCallbackInterface.OnMoveForward;
                @MoveForward.performed -= m_Wrapper.m_RLGLActionsCallbackInterface.OnMoveForward;
                @MoveForward.canceled -= m_Wrapper.m_RLGLActionsCallbackInterface.OnMoveForward;
                @ChangeScene.started -= m_Wrapper.m_RLGLActionsCallbackInterface.OnChangeScene;
                @ChangeScene.performed -= m_Wrapper.m_RLGLActionsCallbackInterface.OnChangeScene;
                @ChangeScene.canceled -= m_Wrapper.m_RLGLActionsCallbackInterface.OnChangeScene;
                @Select.started -= m_Wrapper.m_RLGLActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_RLGLActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_RLGLActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_RLGLActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveForward.started += instance.OnMoveForward;
                @MoveForward.performed += instance.OnMoveForward;
                @MoveForward.canceled += instance.OnMoveForward;
                @ChangeScene.started += instance.OnChangeScene;
                @ChangeScene.performed += instance.OnChangeScene;
                @ChangeScene.canceled += instance.OnChangeScene;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public RLGLActions @RLGL => new RLGLActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IRLGLActions
    {
        void OnMoveForward(InputAction.CallbackContext context);
        void OnChangeScene(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
