//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/PlayerAction.inputactions
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

public partial class @PlayerAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerAction"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""895edf4e-b605-4b5a-8292-06ef400f79e3"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0080f841-71d9-4cb1-bffe-4cf3e3ae256a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""2b520780-5289-45ba-afdc-fb18e172c895"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e93b05de-7186-4386-a4e5-b8a2d3e2fc25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LookKeyboard"",
                    ""type"": ""Value"",
                    ""id"": ""01c8fe31-f3eb-4187-a5c4-165d892458d7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cc0c57a9-a320-4f8e-b539-4987c9a2afea"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6c19a66-b60d-4517-ba61-481d53b03f47"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4666d488-cb64-4c18-a226-ef73f46b1e16"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df466da4-df0b-4597-b2d7-41bdd3132713"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""63c5b3b4-9c52-4abb-9206-ca25bb655484"",
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
                    ""id"": ""050ed212-276a-47a8-9375-b2d4e8e3de72"",
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
                    ""id"": ""00c30109-6f31-42fc-8fa1-3b78e4d3860a"",
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
                    ""id"": ""580a726f-b7d2-4365-b072-5a7bc62c6d9f"",
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
                    ""id"": ""5ec87573-337d-4504-9a9c-b8079c1cfc03"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8719de38-2755-4a26-8125-f8b246af45ce"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""69ca23a1-3a61-4897-bbd8-444343562282"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookKeyboard"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6ea65af9-0822-45e4-a0ca-c67f4c2a5703"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""08051fbf-81e8-4fac-9b18-682639a13bad"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Editor"",
            ""id"": ""4b8d7b64-6f92-4fae-ba1b-39c8bdf6a08d"",
            ""actions"": [
                {
                    ""name"": ""EnableEditor"",
                    ""type"": ""Button"",
                    ""id"": ""1dd703ce-56a7-426b-869f-def5d55c7921"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AddItem1"",
                    ""type"": ""Button"",
                    ""id"": ""2e542e26-343c-45de-a83f-7eae808ac640"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AddItem2"",
                    ""type"": ""Button"",
                    ""id"": ""d49c1802-c8d1-4d62-9f50-9151acdfbf9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DropItem"",
                    ""type"": ""Button"",
                    ""id"": ""2a3af6d4-e91b-4c16-a076-9d603f622639"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Save"",
                    ""type"": ""Button"",
                    ""id"": ""97070ba8-859f-48a9-bdcd-26e4749d6a2e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26eb5948-2d4e-47e2-a425-4af707ae45d8"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableEditor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60e94311-a1e7-45a1-be72-e8f55af3bc2f"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AddItem1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82dc74a7-7b2f-43e6-b244-8fbfcb64f368"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AddItem2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d5a6bfd-c605-4d55-8ef5-8bf09ce1e77c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c61f8507-0144-4317-a0d2-4c974d344b3b"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Save"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_LookKeyboard = m_Player.FindAction("LookKeyboard", throwIfNotFound: true);
        // Editor
        m_Editor = asset.FindActionMap("Editor", throwIfNotFound: true);
        m_Editor_EnableEditor = m_Editor.FindAction("EnableEditor", throwIfNotFound: true);
        m_Editor_AddItem1 = m_Editor.FindAction("AddItem1", throwIfNotFound: true);
        m_Editor_AddItem2 = m_Editor.FindAction("AddItem2", throwIfNotFound: true);
        m_Editor_DropItem = m_Editor.FindAction("DropItem", throwIfNotFound: true);
        m_Editor_Save = m_Editor.FindAction("Save", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_LookKeyboard;
    public struct PlayerActions
    {
        private @PlayerAction m_Wrapper;
        public PlayerActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @LookKeyboard => m_Wrapper.m_Player_LookKeyboard;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @LookKeyboard.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookKeyboard;
                @LookKeyboard.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookKeyboard;
                @LookKeyboard.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookKeyboard;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @LookKeyboard.started += instance.OnLookKeyboard;
                @LookKeyboard.performed += instance.OnLookKeyboard;
                @LookKeyboard.canceled += instance.OnLookKeyboard;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Editor
    private readonly InputActionMap m_Editor;
    private IEditorActions m_EditorActionsCallbackInterface;
    private readonly InputAction m_Editor_EnableEditor;
    private readonly InputAction m_Editor_AddItem1;
    private readonly InputAction m_Editor_AddItem2;
    private readonly InputAction m_Editor_DropItem;
    private readonly InputAction m_Editor_Save;
    public struct EditorActions
    {
        private @PlayerAction m_Wrapper;
        public EditorActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @EnableEditor => m_Wrapper.m_Editor_EnableEditor;
        public InputAction @AddItem1 => m_Wrapper.m_Editor_AddItem1;
        public InputAction @AddItem2 => m_Wrapper.m_Editor_AddItem2;
        public InputAction @DropItem => m_Wrapper.m_Editor_DropItem;
        public InputAction @Save => m_Wrapper.m_Editor_Save;
        public InputActionMap Get() { return m_Wrapper.m_Editor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EditorActions set) { return set.Get(); }
        public void SetCallbacks(IEditorActions instance)
        {
            if (m_Wrapper.m_EditorActionsCallbackInterface != null)
            {
                @EnableEditor.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnEnableEditor;
                @EnableEditor.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnEnableEditor;
                @EnableEditor.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnEnableEditor;
                @AddItem1.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem1;
                @AddItem1.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem1;
                @AddItem1.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem1;
                @AddItem2.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem2;
                @AddItem2.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem2;
                @AddItem2.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem2;
                @DropItem.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnDropItem;
                @DropItem.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnDropItem;
                @DropItem.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnDropItem;
                @Save.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
                @Save.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
                @Save.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
            }
            m_Wrapper.m_EditorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EnableEditor.started += instance.OnEnableEditor;
                @EnableEditor.performed += instance.OnEnableEditor;
                @EnableEditor.canceled += instance.OnEnableEditor;
                @AddItem1.started += instance.OnAddItem1;
                @AddItem1.performed += instance.OnAddItem1;
                @AddItem1.canceled += instance.OnAddItem1;
                @AddItem2.started += instance.OnAddItem2;
                @AddItem2.performed += instance.OnAddItem2;
                @AddItem2.canceled += instance.OnAddItem2;
                @DropItem.started += instance.OnDropItem;
                @DropItem.performed += instance.OnDropItem;
                @DropItem.canceled += instance.OnDropItem;
                @Save.started += instance.OnSave;
                @Save.performed += instance.OnSave;
                @Save.canceled += instance.OnSave;
            }
        }
    }
    public EditorActions @Editor => new EditorActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLookKeyboard(InputAction.CallbackContext context);
    }
    public interface IEditorActions
    {
        void OnEnableEditor(InputAction.CallbackContext context);
        void OnAddItem1(InputAction.CallbackContext context);
        void OnAddItem2(InputAction.CallbackContext context);
        void OnDropItem(InputAction.CallbackContext context);
        void OnSave(InputAction.CallbackContext context);
    }
}
