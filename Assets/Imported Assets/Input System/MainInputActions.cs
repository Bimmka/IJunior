// GENERATED AUTOMATICALLY FROM 'Assets/Imported Assets/Input System/MainInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerInputs"",
            ""id"": ""85048c81-2e51-448c-88ed-d9a96eb5e18c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5f325185-88b6-40e1-8d30-584978e3b652"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8a3a4dcf-fe36-46df-9555-8fac821af80c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""32faa663-6797-4be5-9f0b-e06959658051"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1acf26c4-31f3-4a94-9826-cd96f3758b3c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""854dc2f3-2001-4a2d-9524-7431b5312960"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d448f395-8e14-4d25-9508-cdaa78a2dbfa"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""ec91bdc1-d146-422d-a74a-6ad80332ffc0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""25ece450-17cd-4c58-930b-30024120a5bf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1390f69e-08b0-4fe3-a687-98325ff8be2f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e0bb9dc9-9f3f-40c8-8a1f-8b6957efa766"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""aa196073-b396-4c2f-97d9-55634797072b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c3f96cea-a640-40d5-b73d-215c96e819b9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RigidBodyInputs"",
            ""id"": ""c5a50c74-70bf-47a3-925e-d60accfbba80"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cc7a0bea-ee5b-4c79-9dde-7392993fa794"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scatter"",
                    ""type"": ""Button"",
                    ""id"": ""d1de495b-897a-42b7-9a83-3e1414ca9413"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""429cbaa8-fa73-452b-ac04-0a2fab18501a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f17d26c0-ccbf-4411-855b-96dcb9f854ea"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scatter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInputs
        m_PlayerInputs = asset.FindActionMap("PlayerInputs", throwIfNotFound: true);
        m_PlayerInputs_Move = m_PlayerInputs.FindAction("Move", throwIfNotFound: true);
        // RigidBodyInputs
        m_RigidBodyInputs = asset.FindActionMap("RigidBodyInputs", throwIfNotFound: true);
        m_RigidBodyInputs_Up = m_RigidBodyInputs.FindAction("Up", throwIfNotFound: true);
        m_RigidBodyInputs_Scatter = m_RigidBodyInputs.FindAction("Scatter", throwIfNotFound: true);
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

    // PlayerInputs
    private readonly InputActionMap m_PlayerInputs;
    private IPlayerInputsActions m_PlayerInputsActionsCallbackInterface;
    private readonly InputAction m_PlayerInputs_Move;
    public struct PlayerInputsActions
    {
        private @MainInputActions m_Wrapper;
        public PlayerInputsActions(@MainInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerInputs_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInputsActions instance)
        {
            if (m_Wrapper.m_PlayerInputsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PlayerInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PlayerInputsActions @PlayerInputs => new PlayerInputsActions(this);

    // RigidBodyInputs
    private readonly InputActionMap m_RigidBodyInputs;
    private IRigidBodyInputsActions m_RigidBodyInputsActionsCallbackInterface;
    private readonly InputAction m_RigidBodyInputs_Up;
    private readonly InputAction m_RigidBodyInputs_Scatter;
    public struct RigidBodyInputsActions
    {
        private @MainInputActions m_Wrapper;
        public RigidBodyInputsActions(@MainInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_RigidBodyInputs_Up;
        public InputAction @Scatter => m_Wrapper.m_RigidBodyInputs_Scatter;
        public InputActionMap Get() { return m_Wrapper.m_RigidBodyInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RigidBodyInputsActions set) { return set.Get(); }
        public void SetCallbacks(IRigidBodyInputsActions instance)
        {
            if (m_Wrapper.m_RigidBodyInputsActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_RigidBodyInputsActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_RigidBodyInputsActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_RigidBodyInputsActionsCallbackInterface.OnUp;
                @Scatter.started -= m_Wrapper.m_RigidBodyInputsActionsCallbackInterface.OnScatter;
                @Scatter.performed -= m_Wrapper.m_RigidBodyInputsActionsCallbackInterface.OnScatter;
                @Scatter.canceled -= m_Wrapper.m_RigidBodyInputsActionsCallbackInterface.OnScatter;
            }
            m_Wrapper.m_RigidBodyInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Scatter.started += instance.OnScatter;
                @Scatter.performed += instance.OnScatter;
                @Scatter.canceled += instance.OnScatter;
            }
        }
    }
    public RigidBodyInputsActions @RigidBodyInputs => new RigidBodyInputsActions(this);
    public interface IPlayerInputsActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IRigidBodyInputsActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnScatter(InputAction.CallbackContext context);
    }
}
