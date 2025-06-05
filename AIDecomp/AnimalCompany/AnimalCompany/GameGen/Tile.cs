// Decompiled with Xera AI Decompiler
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Runtime.CompilerServices;

namespace AnimalCompany.GameGen
{
    public class Tile : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class <>c
        {
            public static readonly <>c <>9 = new <>c();
            public static Func<Socket, bool> <>9__4_0;

            static <>c() { }

            public <>c() { }

            internal bool <GetRandomSocket>b__4_0(Socket x)
            {
                return x != null;
            }
        }

        public Bounds bounds;
        
        [HideArrayElementLabel]
        [Space]
        public List<Socket> sockets;

        public Tile()
        {
            sockets = new List<Socket>();
        }

        public Socket GetRandomSocket(bool biasForEntance = false)
        {
            if (biasForEntance)
            {
                var entranceSockets = sockets.Where(<>c.<>9__4_0 ?? (<>c.<>9__4_0 = <>c.<>9.<GetRandomSocket>b__4_0)).ToList();
                if (entranceSockets.Count > 0)
                {
                    int randomIndex = UnityEngine.Random.Range(0, entranceSockets.Count);
                    return entranceSockets[randomIndex];
                }
            }

            if (sockets != null && sockets.Count > 0)
            {
                int randomIndex = UnityEngine.Random.Range(0, sockets.Count);
                return sockets[randomIndex];
            }

            return null;
        }

        public Bounds GetWorldBounds()
        {
            if (transform != null)
            {
                Vector3 center = transform.TransformPoint(bounds.center);
                Vector3 size = transform.TransformVector(bounds.size);
                
                // Calculate absolute values for size components
                size.x = Mathf.Abs(size.x);
                size.y = Mathf.Abs(size.y);
                size.z = Mathf.Abs(size.z);
                
                return new Bounds(center, size);
            }
            
            return bounds;
        }

        public void OnDrawGizmos()
        {
            Gizmos.color = Color.white;
            
            if (transform != null)
            {
                Gizmos.matrix = transform.localToWorldMatrix;
                Gizmos.DrawWireCube(bounds.center, bounds.size);
            }
        }

        public virtual void RenderTile(Archetype archetype)
        {
            if (archetype != null && archetype.prefab != null)
            {
                GameObject instance = Instantiate(archetype.prefab, transform);
                instance.name = archetype.prefab.name;
                instance.transform.parent = transform;
                instance.transform.localPosition = Vector3.zero;
                instance.transform.localRotation = Quaternion.identity;
                instance.layer = 20;
                
                BoxCollider collider = instance.GetComponent<BoxCollider>();
                if (collider != null)
                {
                    collider.center = bounds.center;
                    collider.size = bounds.size * 2f;
                    collider.isTrigger = true;
                }
                
                var tileComponent = instance.GetComponent<Tile>();
                if (tileComponent != null)
                {
                    tileComponent.bounds = bounds;
                }
            }
        }
    }
}