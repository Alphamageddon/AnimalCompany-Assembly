using UnityEngine;

namespace AnimalCompany
{
    public class DebouncedPlaySFX : MonoBehaviour
    {
        public CollisionTrigger collisionTrigger;
        public AudioSource audioSource;
        public float debounceTime = 60f;
        private float lastPlayedTime = -1f;

        public DebouncedPlaySFX()
        {
            debounceTime = 60f;
        }

        private void Awake()
        {
            lastPlayedTime = -debounceTime;
        }

        private void OnEnable()
        {
            if (collisionTrigger != null)
            {
                collisionTrigger.OnTriggerEntered += PlaySFX;
            }
        }

        private void OnDisable()
        {
            if (collisionTrigger != null)
            {
                collisionTrigger.OnTriggerEntered -= PlaySFX;
            }
        }

        private void PlaySFX(Collider other)
        {
            if (other == null) return;
            
            GameObject otherGameObject = other.gameObject;
            if (otherGameObject == null) return;
            
            int layer = otherGameObject.layer;
            
            float currentTime = Time.time;
            float nextAllowedTime = lastPlayedTime + debounceTime;
            
            if (currentTime >= nextAllowedTime)
            {
                if (audioSource != null)
                {
                    audioSource.Play();
                    lastPlayedTime = Time.time;
                }
            }
        }
    }
}