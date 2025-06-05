// Decompiled with Xera AI Decompiler
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;

namespace AnimalCompany.GameGen
{
    public class Socket : MonoBehaviour
    {
        public SocketType socketType;
        
        [Tooltip("Sometimes during generation sockets are randomly chosen but biased towards entrances. Set this flag if you want players to enter from specific sockets. Remember that the generator is non-linear, so plays might not always enter from an entrance.")]
        public bool useAsEntrance;
        
        [Space]
        [Tooltip("A random open variant is used when the socket is connected to another tile. Aka an open doorway.")]
        public List<GameObject> openVariants;
        
        [Tooltip("A random closed variant is used when the socket is not connected to another tile. Aka a closed doorway.")]
        public List<GameObject> closedVariants;
        
        public Bounds lastEvaluatedBounds;
        
        [CompilerGenerated]
        private bool <isOpen>k__BackingField;

        public bool isOpen
        {
            [CompilerGenerated]
            get { return <isOpen>k__BackingField; }
            [CompilerGenerated]
            private set { <isOpen>k__BackingField = value; }
        }

        public Socket()
        {
            openVariants = new List<GameObject>();
            closedVariants = new List<GameObject>();
        }

        public void SetOpen(bool open)
        {
            isOpen = open;
            
            // Deactivate all variants first
            if (openVariants != null)
            {
                foreach (GameObject variant in openVariants)
                {
                    if (variant != null)
                        variant.SetActive(false);
                }
            }
            
            if (closedVariants != null)
            {
                foreach (GameObject variant in closedVariants)
                {
                    if (variant != null)
                        variant.SetActive(false);
                }
            }
            
            // Activate appropriate variant
            List<GameObject> targetList = open ? openVariants : closedVariants;
            if (targetList != null && targetList.Count > 0)
            {
                int randomIndex = UnityEngine.Random.Range(0, targetList.Count);
                GameObject selectedVariant = targetList[randomIndex];
                if (selectedVariant != null)
                    selectedVariant.SetActive(true);
            }
        }

        private void OnDrawGizmos()
        {
            DrawGizmoInternal(0.25f);
        }

        private void OnDrawGizmosSelected()
        {
            DrawGizmoInternal(1.0f);
        }

        private void DrawGizmoInternal(float opacity)
        {
            Color gizmoColor = Color.white;
            gizmoColor.a = opacity;
            Gizmos.color = gizmoColor;
            
            // Draw socket type specific visualization
            switch (socketType)
            {
                case SocketType.Door:
                    Gizmos.color = Color.green * opacity;
                    break;
                case SocketType.Window:
                    Gizmos.color = Color.blue * opacity;
                    break;
                default:
                    Gizmos.color = Color.white * opacity;
                    break;
            }
            
            Transform t = transform;
            if (t != null)
            {
                Gizmos.matrix = t.localToWorldMatrix;
                
                Vector3 size = new Vector3(0.5f, 0.5f, 0.1f);
                Gizmos.DrawWireCube(Vector3.zero, size);
                
                // Draw direction indicator
                Gizmos.color = Color.red * opacity;
                Gizmos.DrawLine(Vector3.zero, Vector3.forward * 0.25f);
                Gizmos.DrawLine(Vector3.zero, Vector3.back * 0.25f);
                Gizmos.DrawLine(Vector3.left * 0.25f, Vector3.right * 0.25f);
                Gizmos.DrawLine(Vector3.down * 0.25f, Vector3.up * 0.25f);
            }
        }
    }
}