using UnityEngine;

namespace AnimalCompany
{
    public class TriggerUtilities
    {
        public TriggerUtilities()
        {
        }

        public static bool TryGetItemFromCollider(Collider col, out GrabbableItem grabbableItem)
        {
            grabbableItem = null;
            
            if (col == null)
                return false;

            Rigidbody attachedRigidbody = col.attachedRigidbody;
            
            if (attachedRigidbody != null)
            {
                col = attachedRigidbody.GetComponent<Collider>();
            }

            grabbableItem = col.GetComponent<GrabbableItem>();
            
            return grabbableItem != null;
        }

        public static bool TryGetNetPlayerFromCollider(Collider col, out NetPlayer netPlayer)
        {
            netPlayer = null;
            
            if (col == null)
                return false;

            netPlayer = col.GetComponent<NetPlayer>();
            
            return netPlayer != null;
        }
    }
}