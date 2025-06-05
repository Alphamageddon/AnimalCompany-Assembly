// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class TeleportPlayerTrigger : MonoBehaviour
    {
        public Transform teleportLocation;

        public TeleportPlayerTrigger()
        {
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other != null && other.CompareTag("Player"))
            {
                PlayerController playerController = other.GetComponent<PlayerController>();
                if (playerController != null && teleportLocation != null)
                {
                    playerController.Respawn(teleportLocation.position, false);
                }
            }
        }
    }
}