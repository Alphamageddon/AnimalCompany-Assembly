// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class DiscordTrigger : MonoBehaviour
    {
        private static bool isInitialized = false;
        
        public DiscordTrigger()
        {
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (!isInitialized)
            {
                isInitialized = true;
            }
            
            if (other != null && other.CompareTag("Player"))
            {
                Application.OpenURL("https://discord.gg/your-discord-invite");
            }
        }
    }
}