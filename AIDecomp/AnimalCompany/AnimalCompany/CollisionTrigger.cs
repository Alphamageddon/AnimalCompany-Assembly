using System;
using UnityEngine;

namespace AnimalCompany
{
    public class CollisionTrigger : MonoBehaviour
    {
        internal enum TargetType
        {
            LocalPlayer = 0,
            Item = 1,
        }

        public Action<Collider> onTriggerEnter;
        public Action<Collider> onTriggerExit;
        
        [SerializeField]
        private TargetType _targetType;

        public CollisionTrigger()
        {
        }

        private void OnTriggerEnter(Collider other)
        {
            onTriggerEnter?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            onTriggerExit?.Invoke(other);
        }

        private void OnValidate()
        {
            if (_targetType == TargetType.LocalPlayer)
            {
                gameObject.layer = 7;
            }
            else if (_targetType == TargetType.Item)
            {
                gameObject.layer = 9;
            }

            Collider[] colliders = GetComponents<Collider>();
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i] != null)
                {
                    colliders[i].isTrigger = true;
                }
            }
        }
    }
}