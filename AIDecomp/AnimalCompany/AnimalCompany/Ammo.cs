// Decompiled with Xera AI Decompiler
using System;
using System.Linq;
using UnityEngine;
using System.Runtime.CompilerServices;

namespace AnimalCompany
{
    public class Ammo : MonoBehaviour
    {
        private GrabbableItem _grabbable;
        private LayerMask _gunCheckLayerMask;

        public Ammo()
        {
        }

        private void Awake()
        {
            _gunCheckLayerMask = LayerMask.GetMask("Gun") | LayerMask.GetMask("Weapon");
            _grabbable = GetComponent<GrabbableItem>();
            
            if (_grabbable != null)
            {
                _grabbable.OnUse += HandleOnUse;
            }
        }

        private void OnDestroy()
        {
            if (_grabbable != null)
            {
                _grabbable.OnUse -= HandleOnUse;
            }
        }

        private void HandleOnUse()
        {
            if (CheckAndReload())
            {
                if (_grabbable != null)
                {
                    _grabbable.RespawnOrDespawn();
                }
            }
        }

        private bool CheckAndReload()
        {
            Vector3 position = transform.position;
            Collider[] colliders = Physics.OverlapSphere(position, 0.25f, _gunCheckLayerMask);
            
            if (colliders != null && colliders.Length > 0)
            {
                Array.Sort(colliders, CheckAndReloadComparer);
                
                for (int i = 0; i < colliders.Length; i++)
                {
                    Collider collider = colliders[i];
                    if (collider == null) continue;
                    
                    Rigidbody rigidbody = collider.attachedRigidbody;
                    GrabbableItem grabbableItem = null;
                    
                    if (rigidbody != null)
                    {
                        grabbableItem = rigidbody.GetComponent<GrabbableItem>();
                    }
                    
                    if (grabbableItem != null)
                    {
                        Shotgun shotgun = grabbableItem as Shotgun;
                        if (shotgun != null)
                        {
                            shotgun.RPC_Reload();
                            return true;
                        }
                    }
                }
            }
            
            return false;
        }

        [CompilerGenerated]
        private int CheckAndReloadComparer(Collider a, Collider b)
        {
            if (a == null || b == null) return 0;
            
            Vector3 thisPos = transform.position;
            Vector3 aPos = a.transform.position;
            Vector3 bPos = b.transform.position;
            
            float distanceA = Vector3.Distance(thisPos, aPos);
            float distanceB = Vector3.Distance(thisPos, bPos);
            
            return distanceA.CompareTo(distanceB);
        }

        [CompilerGenerated]
        private int <CheckAndReload>b__5_0(Collider a, Collider b)
        {
            return CheckAndReloadComparer(a, b);
        }
    }
}