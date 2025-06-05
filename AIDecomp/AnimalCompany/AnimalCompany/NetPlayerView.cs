// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany
{
    public class NetPlayerView : MonoBehaviour
    {
        [SerializeField]
        private MeshRenderer[] _bodyRenderers;
        
        [SerializeField]
        private Transform _headTransform;
        
        [SerializeField]
        private Transform _rightHandTransform;
        
        [SerializeField]
        private Transform _leftHandTransform;
        
        [SerializeField]
        private Transform _bodyTransform;
        
        [SerializeField]
        private Transform _rightArmTransform;
        
        [SerializeField]
        private Transform _leftArmTransform;
        
        [SerializeField]
        private Transform _rightShoulderTransform;
        
        [SerializeField]
        private Transform _leftShoulderTransform;
        
        private Color _color;
        private Dictionary<Material, Material> _instancedMaterials;

        public NetPlayerView()
        {
            _instancedMaterials = new Dictionary<Material, Material>();
        }

        public void SetColor(Color color)
        {
            _color = color;
            
            if (_instancedMaterials != null)
            {
                foreach (Material material in _instancedMaterials.Values)
                {
                    if (material != null)
                    {
                        material.color = color;
                    }
                }
            }
        }

        public void Setup()
        {
            if (_bodyRenderers != null)
            {
                for (int i = 0; i < _bodyRenderers.Length; i++)
                {
                    MeshRenderer renderer = _bodyRenderers[i];
                    if (renderer != null)
                    {
                        Material sharedMaterial = renderer.sharedMaterial;
                        if (_instancedMaterials != null && sharedMaterial != null)
                        {
                            if (!_instancedMaterials.TryGetValue(sharedMaterial, out Material instancedMaterial))
                            {
                                instancedMaterial = new Material(sharedMaterial);
                                _instancedMaterials.Add(sharedMaterial, instancedMaterial);
                            }
                            renderer.sharedMaterial = instancedMaterial;
                        }
                    }
                }
            }
        }

        public void UpdateBodyView()
        {
            if (_headTransform != null && _bodyTransform != null)
            {
                Vector3 headPosition = _headTransform.position;
                Vector3 bodyUp = _bodyTransform.up;
                Vector3 offset = bodyUp * 0.1f;
                _bodyTransform.position = headPosition - offset;
                
                Vector3 headForward = _headTransform.forward;
                Vector3 lookDirection = new Vector3(headForward.x, 0f, headForward.z).normalized;
                if (lookDirection != Vector3.zero)
                {
                    _bodyTransform.rotation = Quaternion.LookRotation(lookDirection);
                }
            }

            if (_rightHandTransform != null && _rightArmTransform != null)
            {
                Vector3 rightHandPos = _rightHandTransform.position;
                _rightArmTransform.position = rightHandPos;
                
                if (_rightShoulderTransform != null)
                {
                    Vector3 shoulderPos = _rightShoulderTransform.position;
                    Vector3 armDirection = (rightHandPos - shoulderPos).normalized;
                    if (armDirection != Vector3.zero)
                    {
                        _rightArmTransform.rotation = Quaternion.LookRotation(armDirection);
                    }
                }
            }

            if (_leftHandTransform != null && _leftArmTransform != null)
            {
                Vector3 leftHandPos = _leftHandTransform.position;
                _leftArmTransform.position = leftHandPos;
                
                if (_leftShoulderTransform != null)
                {
                    Vector3 shoulderPos = _leftShoulderTransform.position;
                    Vector3 armDirection = (leftHandPos - shoulderPos).normalized;
                    if (armDirection != Vector3.zero)
                    {
                        _leftArmTransform.rotation = Quaternion.LookRotation(armDirection);
                    }
                }
            }
        }
    }
}