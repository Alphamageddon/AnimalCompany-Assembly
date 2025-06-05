// Decompiled with Xera AI Decompiler
using System;
using System.Collections;
using UnityEngine;

namespace AnimalCompany
{
    public class TerminalKeyInput : MonoBehaviour
    {
        private const float PRESS_DEBOUNCE_TIME = 0.25f;
        
        public TerminalKeyType keyType;
        public KeyCode keyCode;
        public string keyData;
        public Transform translateTransform;
        public RandomSFX keyPressSFX;
        public TerminalKeyInputListener keyInputListener;
        
        private int tweenID;
        private float _lastKeyPressTime;

        public TerminalKeyInput()
        {
        }

        private void OnDestroy()
        {
            LeanTween.cancel(tweenID);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other != null)
            {
                Rigidbody attachedRigidbody = other.attachedRigidbody;
                if (attachedRigidbody == null)
                {
                    GameObject gameObject = other.gameObject;
                    if (gameObject != null)
                    {
                        attachedRigidbody = gameObject.GetComponent<Rigidbody>();
                        if (attachedRigidbody != null)
                        {
                            Press();
                        }
                    }
                }
            }
        }

        public void Press()
        {
            float currentTime = Time.time;
            if (currentTime - _lastKeyPressTime < PRESS_DEBOUNCE_TIME)
                return;

            Vector3 position = transform.position;
            
            if (keyPressSFX != null)
            {
                keyPressSFX.Play(true, position);
            }

            LeanTween.cancel(tweenID);

            LTDescr tween = LeanTween.value(0f, 1f, 0.1f)
                .setEaseOutCirc()
                .setOnUpdate((float val) => <Press>b__11_0(val))
                .setOnComplete(() => <Press>b__11_1());

            if (tween != null)
            {
                tweenID = tween.id;
            }

            if (keyInputListener != null)
            {
                keyInputListener.OnKeyPressed(keyType, keyCode, keyData);
            }

            _lastKeyPressTime = currentTime;
        }

        private void <Press>b__11_0(float val)
        {
            if (translateTransform == null)
            {
                LeanTween.cancel(tweenID);
                return;
            }

            Vector3 localPosition = translateTransform.localPosition;
            float pressDepth = Mathf.Min(1f, val) * 0.02f;
            localPosition.y = Mathf.Max(0f, -pressDepth);
            translateTransform.localPosition = localPosition;
        }

        private void <Press>b__11_1()
        {
            if (translateTransform == null)
                return;

            translateTransform.localPosition = Vector3.zero;
        }
    }
}