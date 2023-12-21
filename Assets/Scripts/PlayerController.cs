//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/PlayerController.inputactions
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

public partial class @PlayerController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""06729447-b255-4d50-8bd1-c8d59964025f"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a518616c-fe7d-435d-8f11-efaf8a8317d9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c93a7360-9dc5-4d9d-ae50-5a3dafb13e1a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""751f35af-1e96-4fd9-9519-91e0cb3b11f1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b0ca5577-b545-46f1-88af-13b1bf13acf0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bed0ceaa-c03e-40bf-ad9e-f998ad0c0d14"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""07d99632-55a4-4a9a-ac17-490146e2eacd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PlayerActions"",
            ""id"": ""a8e3207e-9e2d-408a-ae18-149c4111ac36"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""036f1e51-02ba-4bd1-ac28-14373dc6ebfa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ChangeWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""2ee3c120-68f1-4ae8-940c-4f61eaf7dc93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Detonate"",
                    ""type"": ""Button"",
                    ""id"": ""af76d584-65f0-4d50-a9d4-4ff68dd175a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a0967cb9-79a8-4d07-8347-07704433e993"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Activate"",
                    ""type"": ""Button"",
                    ""id"": ""5486b104-19d3-4d82-8b0b-b48f955a2a31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShootTwo"",
                    ""type"": ""Value"",
                    ""id"": ""e57abe9b-f121-4d51-81d9-770a5c22fd5c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""b83023ee-454d-40e8-99a0-7a9059759b36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0a86ac66-00d0-491c-91fa-c7abae20bb42"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""81400bb3-cafe-4dda-a011-5b782f733ea1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""99ea93c9-2741-45bd-b055-f91059791f2d"",
                    ""path"": ""<Keyboard>/#(Q)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8aea90de-7240-4da6-b227-8c31e0d0f345"",
                    ""path"": ""<Keyboard>/#(E)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ddf46a5f-50f0-481e-a485-1ac47633c2c1"",
                    ""path"": ""<Keyboard>/#(1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""a9e3a58b-f916-4103-b25f-5d66730b2b8a"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""2cd85bf2-fbd6-4dec-abb3-7fe2a713543f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""2c23c4e6-c3a4-4394-bbab-e185b081041a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2e574693-8a92-45da-9ad6-75aae5cea92c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Detonate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af443de9-cc5a-4691-8436-0783a398f2fe"",
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
                    ""id"": ""a810b117-301b-44e1-8c65-7fa31a2585a5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""66603827-e5ef-4388-9061-7b7fe6cb19b1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootTwo"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""361d7a33-2042-46f2-b09d-da4ee8ad7586"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d6c74e82-a5fa-4936-ad58-3836f6cddf58"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ffed100b-baf4-41a1-9372-569af7a6e45c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4c2f4181-adbe-4b16-a955-ec04fbe5ee88"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c3519cca-649c-403d-9cb0-99f696777103"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2319e527-d6a3-4504-a93d-693a6f4592c1"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerInteract"",
            ""id"": ""d3e8ad95-9444-4aef-b563-74f0305631eb"",
            ""actions"": [
                {
                    ""name"": ""Activate"",
                    ""type"": ""Button"",
                    ""id"": ""2c715fce-9892-4422-a514-cbe79f959815"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e903d440-f1bc-4f30-8e6f-604fbccf2806"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerMenuActions"",
            ""id"": ""15f14cab-116d-4f39-9569-6f605dd469af"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""f58df91e-7c61-4db9-8baf-2fb093127d04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""00d7d139-080c-4652-afbe-d74c4c6c23c9"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerAim"",
            ""id"": ""049ccdc5-c179-4fd7-9bd4-84eb5ab548e3"",
            ""actions"": [
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fd3cf3eb-8dbf-4bb7-aad1-6ea18c6315e7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""702bbf27-cdbe-403e-9a57-e6858910fafd"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        // PlayerActions
        m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
        m_PlayerActions_Shoot = m_PlayerActions.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerActions_ChangeWeapon = m_PlayerActions.FindAction("ChangeWeapon", throwIfNotFound: true);
        m_PlayerActions_Detonate = m_PlayerActions.FindAction("Detonate", throwIfNotFound: true);
        m_PlayerActions_MousePosition = m_PlayerActions.FindAction("MousePosition", throwIfNotFound: true);
        m_PlayerActions_Activate = m_PlayerActions.FindAction("Activate", throwIfNotFound: true);
        m_PlayerActions_ShootTwo = m_PlayerActions.FindAction("ShootTwo", throwIfNotFound: true);
        m_PlayerActions_Aim = m_PlayerActions.FindAction("Aim", throwIfNotFound: true);
        // PlayerInteract
        m_PlayerInteract = asset.FindActionMap("PlayerInteract", throwIfNotFound: true);
        m_PlayerInteract_Activate = m_PlayerInteract.FindAction("Activate", throwIfNotFound: true);
        // PlayerMenuActions
        m_PlayerMenuActions = asset.FindActionMap("PlayerMenuActions", throwIfNotFound: true);
        m_PlayerMenuActions_Pause = m_PlayerMenuActions.FindAction("Pause", throwIfNotFound: true);
        // PlayerAim
        m_PlayerAim = asset.FindActionMap("PlayerAim", throwIfNotFound: true);
        m_PlayerAim_MousePosition = m_PlayerAim.FindAction("MousePosition", throwIfNotFound: true);
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

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private List<IPlayerMovementActions> m_PlayerMovementActionsCallbackInterfaces = new List<IPlayerMovementActions>();
    private readonly InputAction m_PlayerMovement_Movement;
    public struct PlayerMovementActions
    {
        private @PlayerController m_Wrapper;
        public PlayerMovementActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
        }

        private void UnregisterCallbacks(IPlayerMovementActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
        }

        public void RemoveCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // PlayerActions
    private readonly InputActionMap m_PlayerActions;
    private List<IPlayerActionsActions> m_PlayerActionsActionsCallbackInterfaces = new List<IPlayerActionsActions>();
    private readonly InputAction m_PlayerActions_Shoot;
    private readonly InputAction m_PlayerActions_ChangeWeapon;
    private readonly InputAction m_PlayerActions_Detonate;
    private readonly InputAction m_PlayerActions_MousePosition;
    private readonly InputAction m_PlayerActions_Activate;
    private readonly InputAction m_PlayerActions_ShootTwo;
    private readonly InputAction m_PlayerActions_Aim;
    public struct PlayerActionsActions
    {
        private @PlayerController m_Wrapper;
        public PlayerActionsActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_PlayerActions_Shoot;
        public InputAction @ChangeWeapon => m_Wrapper.m_PlayerActions_ChangeWeapon;
        public InputAction @Detonate => m_Wrapper.m_PlayerActions_Detonate;
        public InputAction @MousePosition => m_Wrapper.m_PlayerActions_MousePosition;
        public InputAction @Activate => m_Wrapper.m_PlayerActions_Activate;
        public InputAction @ShootTwo => m_Wrapper.m_PlayerActions_ShootTwo;
        public InputAction @Aim => m_Wrapper.m_PlayerActions_Aim;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Add(instance);
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @ChangeWeapon.started += instance.OnChangeWeapon;
            @ChangeWeapon.performed += instance.OnChangeWeapon;
            @ChangeWeapon.canceled += instance.OnChangeWeapon;
            @Detonate.started += instance.OnDetonate;
            @Detonate.performed += instance.OnDetonate;
            @Detonate.canceled += instance.OnDetonate;
            @MousePosition.started += instance.OnMousePosition;
            @MousePosition.performed += instance.OnMousePosition;
            @MousePosition.canceled += instance.OnMousePosition;
            @Activate.started += instance.OnActivate;
            @Activate.performed += instance.OnActivate;
            @Activate.canceled += instance.OnActivate;
            @ShootTwo.started += instance.OnShootTwo;
            @ShootTwo.performed += instance.OnShootTwo;
            @ShootTwo.canceled += instance.OnShootTwo;
            @Aim.started += instance.OnAim;
            @Aim.performed += instance.OnAim;
            @Aim.canceled += instance.OnAim;
        }

        private void UnregisterCallbacks(IPlayerActionsActions instance)
        {
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @ChangeWeapon.started -= instance.OnChangeWeapon;
            @ChangeWeapon.performed -= instance.OnChangeWeapon;
            @ChangeWeapon.canceled -= instance.OnChangeWeapon;
            @Detonate.started -= instance.OnDetonate;
            @Detonate.performed -= instance.OnDetonate;
            @Detonate.canceled -= instance.OnDetonate;
            @MousePosition.started -= instance.OnMousePosition;
            @MousePosition.performed -= instance.OnMousePosition;
            @MousePosition.canceled -= instance.OnMousePosition;
            @Activate.started -= instance.OnActivate;
            @Activate.performed -= instance.OnActivate;
            @Activate.canceled -= instance.OnActivate;
            @ShootTwo.started -= instance.OnShootTwo;
            @ShootTwo.performed -= instance.OnShootTwo;
            @ShootTwo.canceled -= instance.OnShootTwo;
            @Aim.started -= instance.OnAim;
            @Aim.performed -= instance.OnAim;
            @Aim.canceled -= instance.OnAim;
        }

        public void RemoveCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);

    // PlayerInteract
    private readonly InputActionMap m_PlayerInteract;
    private List<IPlayerInteractActions> m_PlayerInteractActionsCallbackInterfaces = new List<IPlayerInteractActions>();
    private readonly InputAction m_PlayerInteract_Activate;
    public struct PlayerInteractActions
    {
        private @PlayerController m_Wrapper;
        public PlayerInteractActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Activate => m_Wrapper.m_PlayerInteract_Activate;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInteract; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInteractActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerInteractActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerInteractActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerInteractActionsCallbackInterfaces.Add(instance);
            @Activate.started += instance.OnActivate;
            @Activate.performed += instance.OnActivate;
            @Activate.canceled += instance.OnActivate;
        }

        private void UnregisterCallbacks(IPlayerInteractActions instance)
        {
            @Activate.started -= instance.OnActivate;
            @Activate.performed -= instance.OnActivate;
            @Activate.canceled -= instance.OnActivate;
        }

        public void RemoveCallbacks(IPlayerInteractActions instance)
        {
            if (m_Wrapper.m_PlayerInteractActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerInteractActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerInteractActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerInteractActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerInteractActions @PlayerInteract => new PlayerInteractActions(this);

    // PlayerMenuActions
    private readonly InputActionMap m_PlayerMenuActions;
    private List<IPlayerMenuActionsActions> m_PlayerMenuActionsActionsCallbackInterfaces = new List<IPlayerMenuActionsActions>();
    private readonly InputAction m_PlayerMenuActions_Pause;
    public struct PlayerMenuActionsActions
    {
        private @PlayerController m_Wrapper;
        public PlayerMenuActionsActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_PlayerMenuActions_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMenuActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMenuActionsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMenuActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMenuActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMenuActionsActionsCallbackInterfaces.Add(instance);
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IPlayerMenuActionsActions instance)
        {
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IPlayerMenuActionsActions instance)
        {
            if (m_Wrapper.m_PlayerMenuActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMenuActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMenuActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMenuActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMenuActionsActions @PlayerMenuActions => new PlayerMenuActionsActions(this);

    // PlayerAim
    private readonly InputActionMap m_PlayerAim;
    private List<IPlayerAimActions> m_PlayerAimActionsCallbackInterfaces = new List<IPlayerAimActions>();
    private readonly InputAction m_PlayerAim_MousePosition;
    public struct PlayerAimActions
    {
        private @PlayerController m_Wrapper;
        public PlayerAimActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePosition => m_Wrapper.m_PlayerAim_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_PlayerAim; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerAimActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerAimActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerAimActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerAimActionsCallbackInterfaces.Add(instance);
            @MousePosition.started += instance.OnMousePosition;
            @MousePosition.performed += instance.OnMousePosition;
            @MousePosition.canceled += instance.OnMousePosition;
        }

        private void UnregisterCallbacks(IPlayerAimActions instance)
        {
            @MousePosition.started -= instance.OnMousePosition;
            @MousePosition.performed -= instance.OnMousePosition;
            @MousePosition.canceled -= instance.OnMousePosition;
        }

        public void RemoveCallbacks(IPlayerAimActions instance)
        {
            if (m_Wrapper.m_PlayerAimActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerAimActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerAimActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerAimActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerAimActions @PlayerAim => new PlayerAimActions(this);
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnChangeWeapon(InputAction.CallbackContext context);
        void OnDetonate(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnActivate(InputAction.CallbackContext context);
        void OnShootTwo(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
    public interface IPlayerInteractActions
    {
        void OnActivate(InputAction.CallbackContext context);
    }
    public interface IPlayerMenuActionsActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IPlayerAimActions
    {
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
