// GENERATED AUTOMATICALLY FROM 'Assets/Input System/MainInputActions.inputactions'

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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInputs
        m_PlayerInputs = asset.FindActionMap("PlayerInputs", throwIfNotFound: true);
        m_PlayerInputs_Move = m_PlayerInputs.FindAction("Move", throwIfNotFound: true);
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
    public interface IPlayerInputsActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
