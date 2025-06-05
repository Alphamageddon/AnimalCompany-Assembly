// Decompiled with Xera AI Decompiler
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

namespace AnimalCompany
{
    public class XRInputManager : MonoBehaviour
    {
        private static XRInputManager _instance;
        
        public static Action onLeftTriggerButtonPressed;
        public static Action onLeftTriggerButtonReleased;
        public static Action onRightTriggerButtonPressed;
        public static Action onRightTriggerButtonReleased;
        public static Action onLeftGripButtonPressed;
        public static Action onLeftGripButtonReleased;
        public static Action onRightGripButtonPressed;
        public static Action onRightGripButtonReleased;
        public static Action onLeftPrimaryButtonPressed;
        public static Action onLeftPrimaryButtonReleased;
        public static Action onRightPrimaryButtonPressed;
        public static Action onRightPrimaryButtonReleased;
        public static Action onLeftSecondaryButtonPressed;
        public static Action onLeftSecondaryButtonReleased;
        public static Action onRightSecondaryButtonPressed;
        public static Action onRightSecondaryButtonReleased;
        public static Action onLeftJoystickClickPressed;
        public static Action onLeftJoystickClickReleased;
        public static Action onRightJoystickClickPressed;
        public static Action onRightJoystickClickReleased;
        public static Action onMenuButtonPressed;
        public static Action onMenuButtonReleased;

        [Header("XR Controller")]
        [SerializeField]
        private XRController _xrControllerLeft;
        [SerializeField]
        private XRController _xrControllerRight;
        
        private Dictionary<InputFeatureUsage<bool>, bool> _buttonValuesLeft;
        private Dictionary<InputFeatureUsage<bool>, bool> _buttonValuesRight;

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            else
            {
                Destroy(gameObject);
                return;
            }

            _buttonValuesLeft = new Dictionary<InputFeatureUsage<bool>, bool>();
            _buttonValuesRight = new Dictionary<InputFeatureUsage<bool>, bool>();
        }

        private void OnDestroy()
        {
            if (_instance == this)
            {
                _instance = null;
            }
        }

        private void Update()
        {
            GetButtonEvent(HandSide.Left, CommonUsages.triggerButton, onLeftTriggerButtonPressed, onLeftTriggerButtonReleased);
            GetButtonEvent(HandSide.Right, CommonUsages.triggerButton, onRightTriggerButtonPressed, onRightTriggerButtonReleased);
            
            GetButtonEvent(HandSide.Left, CommonUsages.gripButton, onLeftGripButtonPressed, onLeftGripButtonReleased);
            GetButtonEvent(HandSide.Right, CommonUsages.gripButton, onRightGripButtonPressed, onRightGripButtonReleased);
            
            GetButtonEvent(HandSide.Left, CommonUsages.primaryButton, onLeftPrimaryButtonPressed, onLeftPrimaryButtonReleased);
            GetButtonEvent(HandSide.Right, CommonUsages.primaryButton, onRightPrimaryButtonPressed, onRightPrimaryButtonReleased);
            
            GetButtonEvent(HandSide.Left, CommonUsages.secondaryButton, onLeftSecondaryButtonPressed, onLeftSecondaryButtonReleased);
            GetButtonEvent(HandSide.Right, CommonUsages.secondaryButton, onRightSecondaryButtonPressed, onRightSecondaryButtonReleased);
            
            GetButtonEvent(HandSide.Left, CommonUsages.primary2DAxisClick, onLeftJoystickClickPressed, onLeftJoystickClickReleased);
            GetButtonEvent(HandSide.Right, CommonUsages.primary2DAxisClick, onRightJoystickClickPressed, onRightJoystickClickReleased);
            
            GetButtonEvent(HandSide.Left, CommonUsages.menuButton, onMenuButtonPressed, onMenuButtonReleased);
        }

        private void GetButtonEvent(HandSide side, InputFeatureUsage<bool> inputFeatureUsage, Action onPressed, Action onReleased)
        {
            var buttonValues = side == HandSide.Left ? _buttonValuesLeft : _buttonValuesRight;
            var controller = GetXRController(side);
            
            if (controller == null) return;

            bool currentValue = false;
            controller.inputDevice.TryGetFeatureValue(inputFeatureUsage, out currentValue);

            bool previousValue = false;
            buttonValues.TryGetValue(inputFeatureUsage, out previousValue);

            if (currentValue && !previousValue)
            {
                onPressed?.Invoke();
            }
            else if (!currentValue && previousValue)
            {
                onReleased?.Invoke();
            }

            buttonValues[inputFeatureUsage] = currentValue;
        }

        public static bool GetJoystickValue(HandSide side, out Vector2 value)
        {
            return TryGetFeatureValue(side, CommonUsages.primary2DAxis, out value);
        }

        private static bool TryGetFeatureValue(HandSide side, InputFeatureUsage<Vector2> inputFeatureUsage, out Vector2 value)
        {
            var controller = GetXRController(side);
            if (controller == null)
            {
                value = Vector2.zero;
                return false;
            }

            return controller.inputDevice.TryGetFeatureValue(inputFeatureUsage, out value);
        }

        private static XRController GetXRController(HandSide side)
        {
            if (_instance == null) return null;
            
            return side == HandSide.Left ? _instance._xrControllerLeft : _instance._xrControllerRight;
        }

        public static void SendHapticImpulse(HandSide side, float amplitude, float duration)
        {
            var controller = GetXRController(side);
            if (controller != null)
            {
                controller.SendHapticImpulse(amplitude, duration);
            }
        }

        public static void SendHapticImpulse(AttachedLocation location, float amplitude, float duration)
        {
            HandSide side = location == AttachedLocation.LeftHand ? HandSide.Left : HandSide.Right;
            SendHapticImpulse(side, amplitude, duration);
        }
    }
}