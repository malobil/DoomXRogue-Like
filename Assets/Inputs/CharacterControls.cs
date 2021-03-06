// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/CharacterControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CharacterControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CharacterControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CharacterControls"",
    ""maps"": [
        {
            ""name"": ""CharacterMoves"",
            ""id"": ""b649538c-de9a-4f38-b640-7b8d99e37669"",
            ""actions"": [
                {
                    ""name"": ""Movements"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3197ad5c-24be-4617-8b3b-d2cf934cc7fd"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""b7a2804f-2b3b-4ad5-8a81-d63971eb0ac8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""90886d70-0b44-469d-bd65-39b06487b9f4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shot"",
                    ""type"": ""Button"",
                    ""id"": ""3885ecda-5b9d-48bd-a054-866b92db2599"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell"",
                    ""type"": ""Button"",
                    ""id"": ""01956d9b-70df-4ee0-9347-3220c3ba765b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ultimate"",
                    ""type"": ""Button"",
                    ""id"": ""0e8dad2d-39fc-44ea-9a2a-7b8faacec0f1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bfb64317-1a20-493a-a3ee-4ed9f5cec153"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9101e1f6-7a27-496f-afa9-26770015b70c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6a3d743b-ee59-4ae7-b9d5-533638926142"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""09e14145-4e69-45be-ad3c-98fc25965e17"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f10be376-8001-4134-9495-75a97c89d194"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cf432ea9-ac58-45ea-b8ee-29fb12e50e2d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e266af8e-bc01-4121-b1d7-f53246ddf207"",
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
                    ""id"": ""d4198114-62de-473b-8a76-46bda482d9fc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62e19597-9942-4dd1-8a75-40e2fa985ae3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e351558f-3258-4467-a5f9-58985515a938"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ultimate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterMoves
        m_CharacterMoves = asset.FindActionMap("CharacterMoves", throwIfNotFound: true);
        m_CharacterMoves_Movements = m_CharacterMoves.FindAction("Movements", throwIfNotFound: true);
        m_CharacterMoves_MousePosition = m_CharacterMoves.FindAction("MousePosition", throwIfNotFound: true);
        m_CharacterMoves_Jump = m_CharacterMoves.FindAction("Jump", throwIfNotFound: true);
        m_CharacterMoves_Shot = m_CharacterMoves.FindAction("Shot", throwIfNotFound: true);
        m_CharacterMoves_Spell = m_CharacterMoves.FindAction("Spell", throwIfNotFound: true);
        m_CharacterMoves_Ultimate = m_CharacterMoves.FindAction("Ultimate", throwIfNotFound: true);
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

    // CharacterMoves
    private readonly InputActionMap m_CharacterMoves;
    private ICharacterMovesActions m_CharacterMovesActionsCallbackInterface;
    private readonly InputAction m_CharacterMoves_Movements;
    private readonly InputAction m_CharacterMoves_MousePosition;
    private readonly InputAction m_CharacterMoves_Jump;
    private readonly InputAction m_CharacterMoves_Shot;
    private readonly InputAction m_CharacterMoves_Spell;
    private readonly InputAction m_CharacterMoves_Ultimate;
    public struct CharacterMovesActions
    {
        private @CharacterControls m_Wrapper;
        public CharacterMovesActions(@CharacterControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movements => m_Wrapper.m_CharacterMoves_Movements;
        public InputAction @MousePosition => m_Wrapper.m_CharacterMoves_MousePosition;
        public InputAction @Jump => m_Wrapper.m_CharacterMoves_Jump;
        public InputAction @Shot => m_Wrapper.m_CharacterMoves_Shot;
        public InputAction @Spell => m_Wrapper.m_CharacterMoves_Spell;
        public InputAction @Ultimate => m_Wrapper.m_CharacterMoves_Ultimate;
        public InputActionMap Get() { return m_Wrapper.m_CharacterMoves; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterMovesActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterMovesActions instance)
        {
            if (m_Wrapper.m_CharacterMovesActionsCallbackInterface != null)
            {
                @Movements.started -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnMovements;
                @Movements.performed -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnMovements;
                @Movements.canceled -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnMovements;
                @MousePosition.started -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnMousePosition;
                @Jump.started -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnJump;
                @Shot.started -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnShot;
                @Shot.performed -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnShot;
                @Shot.canceled -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnShot;
                @Spell.started -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnSpell;
                @Spell.performed -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnSpell;
                @Spell.canceled -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnSpell;
                @Ultimate.started -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnUltimate;
                @Ultimate.performed -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnUltimate;
                @Ultimate.canceled -= m_Wrapper.m_CharacterMovesActionsCallbackInterface.OnUltimate;
            }
            m_Wrapper.m_CharacterMovesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movements.started += instance.OnMovements;
                @Movements.performed += instance.OnMovements;
                @Movements.canceled += instance.OnMovements;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shot.started += instance.OnShot;
                @Shot.performed += instance.OnShot;
                @Shot.canceled += instance.OnShot;
                @Spell.started += instance.OnSpell;
                @Spell.performed += instance.OnSpell;
                @Spell.canceled += instance.OnSpell;
                @Ultimate.started += instance.OnUltimate;
                @Ultimate.performed += instance.OnUltimate;
                @Ultimate.canceled += instance.OnUltimate;
            }
        }
    }
    public CharacterMovesActions @CharacterMoves => new CharacterMovesActions(this);
    public interface ICharacterMovesActions
    {
        void OnMovements(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShot(InputAction.CallbackContext context);
        void OnSpell(InputAction.CallbackContext context);
        void OnUltimate(InputAction.CallbackContext context);
    }
}
