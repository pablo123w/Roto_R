//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Scripts/Helo/HeloInput.inputactions
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

public partial class @HeloInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @HeloInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""HeloInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""119f1af5-cb63-45bb-96a5-dabd8d75a563"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0d1a764e-bf45-4947-a961-082f6ba27693"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""30e84166-dfaf-43b0-8b1f-a4963686c05f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""fbb23fb9-1075-428e-ace7-91cc73f70f42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LetGO"",
                    ""type"": ""Value"",
                    ""id"": ""d412ba41-71d5-4d70-a1dc-bd3bd752d5ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""WeaponSwitch_1"",
                    ""type"": ""Value"",
                    ""id"": ""03e3682e-762c-4a51-b3f8-28e22f441827"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""WeaponSwitch_2"",
                    ""type"": ""Button"",
                    ""id"": ""f1693f51-dbac-451b-a048-cdf4720fad00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WeaponSwitch_3"",
                    ""type"": ""Button"",
                    ""id"": ""17669e2a-e7dc-43bd-81d0-c552daa00d44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""84405243-57f5-4e43-bc28-7aa02f2e800d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""water"",
                    ""type"": ""Button"",
                    ""id"": ""8a063e76-309b-433d-a0ec-df14e4b6b506"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Forward Keyboard"",
                    ""id"": ""d53dd5d9-df07-43d4-bcd0-88629cc9c5f2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""f721719c-64be-4866-a37f-d6a990e9d715"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""efa045ab-ed83-4adf-b9b6-46cc14018814"",
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
                    ""id"": ""0e86a6ef-12da-4a8b-bd84-53f790412793"",
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
                    ""id"": ""2ab19acd-35c2-424e-84bb-3d7e671fdc1a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Forward Gamepad"",
                    ""id"": ""76f0051c-890e-4c5a-889a-e476d5407491"",
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
                    ""id"": ""ab473731-be47-4e9a-aeb7-7db842b11978"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8e696b12-9a94-44c6-a9ae-6c76c1c1e5be"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""77f44edf-bb01-4275-baf9-f8608c56e227"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""25e24604-952f-45ca-ab79-a7e03e42d41d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Forward Gamepad"",
                    ""id"": ""c4cfc1a5-c356-4456-8b37-b5f7f13de1df"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d72ffa9a-080b-4545-98c0-79a4a21cf4dc"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8ab0aa5c-5f22-4278-b64a-c27edf04575d"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""230b11dd-958f-4ab0-afe8-e5d1e37ea9f6"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""97e995bc-b6ff-4fa4-a8a6-5c320488a498"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b9375b94-f6d4-414c-9163-c250d6d790e9"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abe71c91-6a69-4b26-a96b-8bfb9286a958"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b744ce8-437a-4300-90eb-edaf1ce9909f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LetGO"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c546e72-d306-41a9-b7e2-13b43b1ff7a5"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LetGO"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72ac2d6d-5d63-4a00-ba2e-5bd07f55f6b9"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSwitch_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a454fa05-deb0-4da5-b676-0a4ec056d1f4"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSwitch_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc407615-f6ed-4624-b007-77625b3129ba"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSwitch_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cafee68-4e8f-4849-96a1-e1602c7cfa56"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3f291bf-11d9-4e5d-9154-bdf2009d64ea"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""water"",
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
        m_Player_Aim = m_Player.FindAction("Aim", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_LetGO = m_Player.FindAction("LetGO", throwIfNotFound: true);
        m_Player_WeaponSwitch_1 = m_Player.FindAction("WeaponSwitch_1", throwIfNotFound: true);
        m_Player_WeaponSwitch_2 = m_Player.FindAction("WeaponSwitch_2", throwIfNotFound: true);
        m_Player_WeaponSwitch_3 = m_Player.FindAction("WeaponSwitch_3", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        m_Player_water = m_Player.FindAction("water", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Aim;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_LetGO;
    private readonly InputAction m_Player_WeaponSwitch_1;
    private readonly InputAction m_Player_WeaponSwitch_2;
    private readonly InputAction m_Player_WeaponSwitch_3;
    private readonly InputAction m_Player_Pause;
    private readonly InputAction m_Player_water;
    public struct PlayerActions
    {
        private @HeloInput m_Wrapper;
        public PlayerActions(@HeloInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Aim => m_Wrapper.m_Player_Aim;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @LetGO => m_Wrapper.m_Player_LetGO;
        public InputAction @WeaponSwitch_1 => m_Wrapper.m_Player_WeaponSwitch_1;
        public InputAction @WeaponSwitch_2 => m_Wrapper.m_Player_WeaponSwitch_2;
        public InputAction @WeaponSwitch_3 => m_Wrapper.m_Player_WeaponSwitch_3;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputAction @water => m_Wrapper.m_Player_water;
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
                @Aim.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @LetGO.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLetGO;
                @LetGO.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLetGO;
                @LetGO.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLetGO;
                @WeaponSwitch_1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwitch_1;
                @WeaponSwitch_1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwitch_1;
                @WeaponSwitch_1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwitch_1;
                @WeaponSwitch_2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwitch_2;
                @WeaponSwitch_2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwitch_2;
                @WeaponSwitch_2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwitch_2;
                @WeaponSwitch_3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwitch_3;
                @WeaponSwitch_3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwitch_3;
                @WeaponSwitch_3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSwitch_3;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @water.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWater;
                @water.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWater;
                @water.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWater;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @LetGO.started += instance.OnLetGO;
                @LetGO.performed += instance.OnLetGO;
                @LetGO.canceled += instance.OnLetGO;
                @WeaponSwitch_1.started += instance.OnWeaponSwitch_1;
                @WeaponSwitch_1.performed += instance.OnWeaponSwitch_1;
                @WeaponSwitch_1.canceled += instance.OnWeaponSwitch_1;
                @WeaponSwitch_2.started += instance.OnWeaponSwitch_2;
                @WeaponSwitch_2.performed += instance.OnWeaponSwitch_2;
                @WeaponSwitch_2.canceled += instance.OnWeaponSwitch_2;
                @WeaponSwitch_3.started += instance.OnWeaponSwitch_3;
                @WeaponSwitch_3.performed += instance.OnWeaponSwitch_3;
                @WeaponSwitch_3.canceled += instance.OnWeaponSwitch_3;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @water.started += instance.OnWater;
                @water.performed += instance.OnWater;
                @water.canceled += instance.OnWater;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnLetGO(InputAction.CallbackContext context);
        void OnWeaponSwitch_1(InputAction.CallbackContext context);
        void OnWeaponSwitch_2(InputAction.CallbackContext context);
        void OnWeaponSwitch_3(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnWater(InputAction.CallbackContext context);
    }
}
