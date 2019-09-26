// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player Controllers.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControllers : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controllers"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""2af6560e-7a3a-4cb5-888f-678bb9ffcfca"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3affe85d-176d-4fb7-8b48-6d95e1dfbf98"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""e64286fd-526d-4d3a-ab1f-1fec09ac17f2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""0f320662-ecc9-4fc4-b9bb-20bf9dc2f36a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8edf9fe7-92b0-4b5e-ba88-56c60b65db2f"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0df809b-a227-49b8-987b-2fd070ab39e2"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b736af0d-0bf7-4cf9-9070-8fcf05c12965"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3684ce7e-dd72-4572-aaee-a12c9a6d0cda"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1084561b-91b5-4363-a9f7-ae4f6eee788b"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3dff6665-5f9e-4831-b851-08631413d9b4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LeftArm"",
            ""id"": ""16866835-5c13-49bd-ab58-ce2461413e84"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""0f44baac-c4f4-4162-947b-415247db8c72"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""280e97fe-58dd-4d2b-8fc6-42cbd90bb338"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""0be7f2b0-f75d-465b-9be8-ee325a57084a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b637a504-7e73-42b6-a9b6-a10474b5361a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa70d908-181a-4570-80ad-f400dfa8cfb3"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9735534b-bf40-4d48-810d-6993b8654490"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RightArm"",
            ""id"": ""edd0aaa1-1404-424d-beee-b19bb61809a0"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""74ef2292-cdbb-492b-882b-bddc89611908"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""9c565e6b-3cdb-4564-b3d8-3531962f91d4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""6e23e5a9-cd43-43dc-a8b0-17112a057868"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d80fbcb7-2593-4a38-9efb-4bb650486598"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37559d5f-8ce0-4d20-a6df-fc8618711eda"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7f6e7fd-f36d-4bea-8e5c-c861f4d8e2c8"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.GetActionMap("Move");
        m_Move_Jump = m_Move.GetAction("Jump");
        m_Move_Left = m_Move.GetAction("Left");
        m_Move_Down = m_Move.GetAction("Down");
        // LeftArm
        m_LeftArm = asset.GetActionMap("LeftArm");
        m_LeftArm_Rotate = m_LeftArm.GetAction("Rotate");
        m_LeftArm_Use = m_LeftArm.GetAction("Use");
        m_LeftArm_Pickup = m_LeftArm.GetAction("Pickup");
        // RightArm
        m_RightArm = asset.GetActionMap("RightArm");
        m_RightArm_Rotate = m_RightArm.GetAction("Rotate");
        m_RightArm_Use = m_RightArm.GetAction("Use");
        m_RightArm_Pickup = m_RightArm.GetAction("Pickup");
    }

    ~PlayerControllers()
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Jump;
    private readonly InputAction m_Move_Left;
    private readonly InputAction m_Move_Down;
    public struct MoveActions
    {
        private PlayerControllers m_Wrapper;
        public MoveActions(PlayerControllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Move_Jump;
        public InputAction @Left => m_Wrapper.m_Move_Left;
        public InputAction @Down => m_Wrapper.m_Move_Down;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                Jump.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                Left.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnLeft;
                Left.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnLeft;
                Left.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnLeft;
                Down.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnDown;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
                Left.started += instance.OnLeft;
                Left.performed += instance.OnLeft;
                Left.canceled += instance.OnLeft;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);

    // LeftArm
    private readonly InputActionMap m_LeftArm;
    private ILeftArmActions m_LeftArmActionsCallbackInterface;
    private readonly InputAction m_LeftArm_Rotate;
    private readonly InputAction m_LeftArm_Use;
    private readonly InputAction m_LeftArm_Pickup;
    public struct LeftArmActions
    {
        private PlayerControllers m_Wrapper;
        public LeftArmActions(PlayerControllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_LeftArm_Rotate;
        public InputAction @Use => m_Wrapper.m_LeftArm_Use;
        public InputAction @Pickup => m_Wrapper.m_LeftArm_Pickup;
        public InputActionMap Get() { return m_Wrapper.m_LeftArm; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftArmActions set) { return set.Get(); }
        public void SetCallbacks(ILeftArmActions instance)
        {
            if (m_Wrapper.m_LeftArmActionsCallbackInterface != null)
            {
                Rotate.started -= m_Wrapper.m_LeftArmActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_LeftArmActionsCallbackInterface.OnRotate;
                Rotate.canceled -= m_Wrapper.m_LeftArmActionsCallbackInterface.OnRotate;
                Use.started -= m_Wrapper.m_LeftArmActionsCallbackInterface.OnUse;
                Use.performed -= m_Wrapper.m_LeftArmActionsCallbackInterface.OnUse;
                Use.canceled -= m_Wrapper.m_LeftArmActionsCallbackInterface.OnUse;
                Pickup.started -= m_Wrapper.m_LeftArmActionsCallbackInterface.OnPickup;
                Pickup.performed -= m_Wrapper.m_LeftArmActionsCallbackInterface.OnPickup;
                Pickup.canceled -= m_Wrapper.m_LeftArmActionsCallbackInterface.OnPickup;
            }
            m_Wrapper.m_LeftArmActionsCallbackInterface = instance;
            if (instance != null)
            {
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.canceled += instance.OnRotate;
                Use.started += instance.OnUse;
                Use.performed += instance.OnUse;
                Use.canceled += instance.OnUse;
                Pickup.started += instance.OnPickup;
                Pickup.performed += instance.OnPickup;
                Pickup.canceled += instance.OnPickup;
            }
        }
    }
    public LeftArmActions @LeftArm => new LeftArmActions(this);

    // RightArm
    private readonly InputActionMap m_RightArm;
    private IRightArmActions m_RightArmActionsCallbackInterface;
    private readonly InputAction m_RightArm_Rotate;
    private readonly InputAction m_RightArm_Use;
    private readonly InputAction m_RightArm_Pickup;
    public struct RightArmActions
    {
        private PlayerControllers m_Wrapper;
        public RightArmActions(PlayerControllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_RightArm_Rotate;
        public InputAction @Use => m_Wrapper.m_RightArm_Use;
        public InputAction @Pickup => m_Wrapper.m_RightArm_Pickup;
        public InputActionMap Get() { return m_Wrapper.m_RightArm; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightArmActions set) { return set.Get(); }
        public void SetCallbacks(IRightArmActions instance)
        {
            if (m_Wrapper.m_RightArmActionsCallbackInterface != null)
            {
                Rotate.started -= m_Wrapper.m_RightArmActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_RightArmActionsCallbackInterface.OnRotate;
                Rotate.canceled -= m_Wrapper.m_RightArmActionsCallbackInterface.OnRotate;
                Use.started -= m_Wrapper.m_RightArmActionsCallbackInterface.OnUse;
                Use.performed -= m_Wrapper.m_RightArmActionsCallbackInterface.OnUse;
                Use.canceled -= m_Wrapper.m_RightArmActionsCallbackInterface.OnUse;
                Pickup.started -= m_Wrapper.m_RightArmActionsCallbackInterface.OnPickup;
                Pickup.performed -= m_Wrapper.m_RightArmActionsCallbackInterface.OnPickup;
                Pickup.canceled -= m_Wrapper.m_RightArmActionsCallbackInterface.OnPickup;
            }
            m_Wrapper.m_RightArmActionsCallbackInterface = instance;
            if (instance != null)
            {
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.canceled += instance.OnRotate;
                Use.started += instance.OnUse;
                Use.performed += instance.OnUse;
                Use.canceled += instance.OnUse;
                Pickup.started += instance.OnPickup;
                Pickup.performed += instance.OnPickup;
                Pickup.canceled += instance.OnPickup;
            }
        }
    }
    public RightArmActions @RightArm => new RightArmActions(this);
    public interface IMoveActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
    }
    public interface ILeftArmActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
    }
    public interface IRightArmActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
    }
}
