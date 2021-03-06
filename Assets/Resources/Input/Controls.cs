//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Resources/Input/Controls.inputactions
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

namespace Input
{
    public partial class @Controls : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""10fa10c9-e129-480d-bf84-a80fe66495f4"",
            ""actions"": [
                {
                    ""name"": ""Press"",
                    ""type"": ""PassThrough"",
                    ""id"": ""387abbda-0db2-4985-bd03-61f9346d2122"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Orientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d72e3f5c-646f-480c-9bc7-b69253c4b5f0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Tilt"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9cf7f7cf-8e77-4c4a-a5df-d32e1c7c2522"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Mouse"",
                    ""id"": ""9becc788-643c-40da-aa55-c765cf8736af"",
                    ""path"": ""OneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""dfb1a34f-07e6-4469-908a-71b725773891"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""bb3192dd-5f1c-42dd-92b3-af3f2c89995d"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Tap"",
                    ""id"": ""4160f757-c3ff-429e-996f-036bea6bda61"",
                    ""path"": ""OneModifier"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""c7c04151-9e3c-40ba-ab44-bbca43899fba"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""c5e7fdbe-1424-4ec5-8e0b-727333cb7af7"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WSAD"",
                    ""id"": ""d6afdac0-a836-4eef-bb5f-e4a7aae4d178"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orientation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a1bcf0eb-9ddc-4c3c-b30f-9169746bfacd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""121b4f11-84f6-4848-96ee-1c5cdd734716"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9af577e1-3464-4d2e-b50d-8ae9939e012d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0a27177c-ee62-48e2-ade7-e4874b9e7038"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a25ebdf5-ea96-4917-9bae-4274819c19ec"",
                    ""path"": ""<Accelerometer>/acceleration"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Main
            m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
            m_Main_Press = m_Main.FindAction("Press", throwIfNotFound: true);
            m_Main_Orientation = m_Main.FindAction("Orientation", throwIfNotFound: true);
            m_Main_Tilt = m_Main.FindAction("Tilt", throwIfNotFound: true);
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

        // Main
        private readonly InputActionMap m_Main;
        private IMainActions m_MainActionsCallbackInterface;
        private readonly InputAction m_Main_Press;
        private readonly InputAction m_Main_Orientation;
        private readonly InputAction m_Main_Tilt;
        public struct MainActions
        {
            private @Controls m_Wrapper;
            public MainActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Press => m_Wrapper.m_Main_Press;
            public InputAction @Orientation => m_Wrapper.m_Main_Orientation;
            public InputAction @Tilt => m_Wrapper.m_Main_Tilt;
            public InputActionMap Get() { return m_Wrapper.m_Main; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
            public void SetCallbacks(IMainActions instance)
            {
                if (m_Wrapper.m_MainActionsCallbackInterface != null)
                {
                    @Press.started -= m_Wrapper.m_MainActionsCallbackInterface.OnPress;
                    @Press.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnPress;
                    @Press.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnPress;
                    @Orientation.started -= m_Wrapper.m_MainActionsCallbackInterface.OnOrientation;
                    @Orientation.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnOrientation;
                    @Orientation.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnOrientation;
                    @Tilt.started -= m_Wrapper.m_MainActionsCallbackInterface.OnTilt;
                    @Tilt.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnTilt;
                    @Tilt.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnTilt;
                }
                m_Wrapper.m_MainActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Press.started += instance.OnPress;
                    @Press.performed += instance.OnPress;
                    @Press.canceled += instance.OnPress;
                    @Orientation.started += instance.OnOrientation;
                    @Orientation.performed += instance.OnOrientation;
                    @Orientation.canceled += instance.OnOrientation;
                    @Tilt.started += instance.OnTilt;
                    @Tilt.performed += instance.OnTilt;
                    @Tilt.canceled += instance.OnTilt;
                }
            }
        }
        public MainActions @Main => new MainActions(this);
        public interface IMainActions
        {
            void OnPress(InputAction.CallbackContext context);
            void OnOrientation(InputAction.CallbackContext context);
            void OnTilt(InputAction.CallbackContext context);
        }
    }
}
