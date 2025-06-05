// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class GorillaQWOPController : MonoBehaviour
    {
        [SerializeField]
        private Transform _headTransform;
        
        [SerializeField]
        private Transform _rightHandTransform;
        
        [SerializeField]
        private Transform _leftHandTransform;
        
        [SerializeField]
        private float _lerpSpeed = 5f;
        
        private Vector3 _targetLeftHandPosition;
        private Vector3 _targetRightHandPosition;

        private void Update()
        {
            // Q key - left hand up
            if (Input.GetKey(KeyCode.Q))
            {
                _targetLeftHandPosition.y += 0.25f * Time.deltaTime;
            }

            // W key - right hand up  
            if (Input.GetKey(KeyCode.W))
            {
                _targetRightHandPosition.y += 0.25f * Time.deltaTime;
            }

            // O key - left hand down
            if (Input.GetKey(KeyCode.O))
            {
                _targetLeftHandPosition.y -= 0.25f * Time.deltaTime;
            }

            // P key - right hand down
            if (Input.GetKey(KeyCode.P))
            {
                _targetRightHandPosition.y -= 0.25f * Time.deltaTime;
            }

            // Lerp hand positions
            float deltaTime = Time.deltaTime;
            float lerpFactor = Mathf.Min(_lerpSpeed * deltaTime, 1f);

            // Update left hand position
            if (_leftHandTransform != null)
            {
                Vector3 currentLeftPos = _leftHandTransform.position;
                Vector3 worldTargetLeft = _headTransform.localToWorldMatrix.MultiplyPoint(_targetLeftHandPosition);
                Vector3 newLeftPos = Vector3.Lerp(currentLeftPos, worldTargetLeft, lerpFactor);
                _leftHandTransform.position = newLeftPos;
            }

            // Update right hand position
            if (_rightHandTransform != null)
            {
                Vector3 currentRightPos = _rightHandTransform.position;
                Vector3 worldTargetRight = _headTransform.localToWorldMatrix.MultiplyPoint(_targetRightHandPosition);
                Vector3 newRightPos = Vector3.Lerp(currentRightPos, worldTargetRight, lerpFactor);
                _rightHandTransform.position = newRightPos;
            }
        }
    }
}