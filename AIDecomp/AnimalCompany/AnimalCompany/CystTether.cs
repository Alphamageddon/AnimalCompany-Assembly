// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class CystTether : MonoBehaviour
    {
        public CystController cyst;

        public CystTether()
        {
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other != null)
            {
                GameObject otherGameObject = other.gameObject;
                if (otherGameObject != null)
                {
                    int layer = otherGameObject.layer;
                    
                    if (cyst != null)
                    {
                        var localPlayer = NetPlayer.localPlayer;
                        cyst.BreakTether(this, localPlayer);
                    }
                }
            }
        }
    }
}