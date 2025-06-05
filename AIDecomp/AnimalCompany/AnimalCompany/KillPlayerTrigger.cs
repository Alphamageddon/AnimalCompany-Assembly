using UnityEngine;

namespace AnimalCompany
{
    public class KillPlayerTrigger : MonoBehaviour
    {
        private const string COMPONENT_NAME = "KillPlayerTrigger";
        
        public RandomSFX deathSFX;
        private bool _isPlayerInTrigger;
        private float _timeToDie = 3.5f;
        private float _timer;

        public KillPlayerTrigger()
        {
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other != null && other.CompareTag("Player"))
            {
                _isPlayerInTrigger = true;
                _timer = 0f;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other != null && other.CompareTag("Player"))
            {
                _isPlayerInTrigger = false;
            }
        }

        private void Update()
        {
            if (_isPlayerInTrigger)
            {
                _timer += Time.deltaTime;
                
                if (_timer >= _timeToDie)
                {
                    _timer = 0f;
                    _isPlayerInTrigger = false;
                    
                    var playerController = FindObjectOfType<PlayerController>();
                    if (playerController != null)
                    {
                        if (deathSFX != null)
                        {
                            deathSFX.PlayRandomSFX();
                        }
                        playerController.PlayerDie();
                    }
                }
            }
        }
    }
}