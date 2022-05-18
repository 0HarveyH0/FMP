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
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Button"",
                    ""id"": ""c68c6c7d-2e9c-4d0d-9c5d-290ec6a6e9c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Click"",
                    ""type"": ""Button"",
                    ""id"": ""ca288301-96e1-4b11-b6c6-6587f87d269d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MMB"",
                    ""type"": ""Button"",
                    ""id"": ""de9b78b8-c1a6-4238-a196-bd5f86badca0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Click"",
                    ""type"": ""Button"",
                    ""id"": ""3b4eaf9e-a8f5-465e-8dcc-d6dea6cdcc48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll Wheel"",
                    ""type"": ""Value"",
                    ""id"": ""5010ffea-4425-4eea-9950-e63fca334a3b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""622de534-3474-44c1-b4b4-e8b4fad18635"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""06f2d81e-77b2-4512-b907-34c699b35132"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""390fdcde-de01-41b7-9173-108be626574f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7189a35c-7fa6-42f7-a17f-039e0bc7feaf"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87958fc9-5c82-4510-bc7a-7a588b4a1ba0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Left Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34fb56f2-2106-48df-873c-5b8321fe060f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Left Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee149a97-d59f-4dbc-a5f5-efd120437734"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MMB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8d77406-de20-45c0-97a6-02736712ea53"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MMB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff103679-95fa-4a1a-b11e-14a6d0db9d41"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Right Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28b1c6b2-15f2-42f7-ab20-f898f981bb1f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Right Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28194e7e-628a-4196-b7bc-afc1e57e665a"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Scroll Wheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2955f07-1eb6-4b32-9c8e-ca5a3d8d81f9"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Scroll Wheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9173e201-ad05-4293-957a-bf6ed6534ba5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da4fc493-5561-4036-9da0-b8025ad5e7d3"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf304566-eb0d-475e-9b33-fcd2f53d6188"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ceca21d-7001-46aa-9a0c-69a1f9022337"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Cancel"",
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
        m_RLGL_Look = m_RLGL.FindAction("Look", throwIfNotFound: true);
        m_RLGL_LeftClick = m_RLGL.FindAction("Left Click", throwIfNotFound: true);
        m_RLGL_MMB = m_RLGL.FindAction("MMB", throwIfNotFound: true);
        m_RLGL_RightClick = m_RLGL.FindAction("Right Click", throwIfNotFound: true);
        m_RLGL_ScrollWheel = m_RLGL.FindAction("Scroll Wheel", throwIfNotFound: true);
        m_RLGL_Enter = m_RLGL.FindAction("Enter", throwIfNotFound: true);
        m_RLGL_Cancel = m_RLGL.FindAction("Cancel", throwIfNotFound: true);
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
    private readonly InputAction m_RLGL_Look;
    private readonly InputAction m_RLGL_LeftClick;
    private readonly InputAction m_RLGL_MMB;
    private readonly InputAction m_RLGL_RightClick;
    private readonly InputAction m_RLGL_ScrollWheel;
    private readonly InputAction m_RLGL_Enter;
    private readonly InputAction m_RLGL_Cancel;
    public struct RLGLActions
    {
        private @FMP m_Wrapper;
        public RLGLActions(@FMP wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveForward => m_Wrapper.m_RLGL_MoveForward;
        public InputAction @ChangeScene => m_Wrapper.m_RLGL_ChangeScene;
        public InputAction @Select => m_Wrapper.m_RLGL_Select;
        public InputAction @Look => m_Wrapper.m_RLGL_Look;
        public InputAction @LeftClick => m_Wrapper.m_RLGL_LeftClick;
        public InputAction @MMB => m_Wrapper.m_RLGL_MMB;
        public InputAction @RightClick => m_Wrapper.m_RLGL_RightClick;
        public InputAction @ScrollWheel => m_Wrapper.m_RLGL_ScrollWheel;
        public InputAction @Enter => m_Wrapper.m_RLGL_Enter;
        public InputAction @Cancel => m_Wrapper.m_RLGL_Cancel;
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
                @Look.started -= m_Wrapper.m_RLGLActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_RLGLActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_RLGLActionsCallbackInterface.OnLook;
                @LeftClick.started -= m_Wrapper.m_RLGLActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_RLGLActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_RLGLActionsCallbackInterface.OnLeftClick;
                @MMB.started -= m_Wrapper.m_RLGLActionsCallbackInterface.OnMMB;
                @MMB.performed -= m_Wrapper.m_RLGLActionsCallbackInterface.OnMMB;
                @MMB.canceled -= m_Wrapper.m_RLGLActionsCallbackInterface.OnMMB;
                @RightClick.started -= m_Wrapper.m_RLGLActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_RLGLActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_RLGLActionsCallbackInterface.OnRightClick;
                @ScrollWheel.started -= m_Wrapper.m_RLGLActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_RLGLActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_RLGLActionsCallbackInterface.OnScrollWheel;
                @Enter.started -= m_Wrapper.m_RLGLActionsCallbackInterface.OnEnter;
                @Enter.performed -= m_Wrapper.m_RLGLActionsCallbackInterface.OnEnter;
                @Enter.canceled -= m_Wrapper.m_RLGLActionsCallbackInterface.OnEnter;
                @Cancel.started -= m_Wrapper.m_RLGLActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_RLGLActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_RLGLActionsCallbackInterface.OnCancel;
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
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @MMB.started += instance.OnMMB;
                @MMB.performed += instance.OnMMB;
                @MMB.canceled += instance.OnMMB;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
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
        void OnLook(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
        void OnMMB(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
