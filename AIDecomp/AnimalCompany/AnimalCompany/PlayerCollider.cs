using System;
using UnityEngine;

namespace AnimalCompany
{
    public class PlayerCollider : MonoBehaviour
    {
        private const int LOCAL_PLAYER_LAYER = 6;
        public Action<PlayerController> onPlayerCollisionEnter;

        public PlayerCollider()
        {
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other != null)
            {
                GameObject otherGameObject = other.gameObject;
                if (otherGameObject != null && otherGameObject.layer == LOCAL_PLAYER_LAYER)
                {
                    PlayerController playerController = otherGameObject.GetComponent<PlayerController>();
                    if (playerController != null && onPlayerCollisionEnter != null)
                    {
                        onPlayerCollisionEnter.Invoke(playerController);
                    }
                }
            }
        }
    }
}