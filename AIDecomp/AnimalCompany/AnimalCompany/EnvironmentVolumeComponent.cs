using UnityEngine;

namespace AnimalCompany
{
    [ExecuteAlways]
    [RequireComponent(typeof(Collider))]
    public class EnvironmentVolumeComponent : MonoBehaviour
    {
        public EnvironmentVolumeProfile profile;
        private Collider _volumeCollider;

        public Collider volumeCollider
        {
            get
            {
                if (_volumeCollider == null)
                {
                    _volumeCollider = GetComponent<Collider>();
                }
                return _volumeCollider;
            }
        }

        public EnvironmentVolumeComponent()
        {
        }

        public Collider get_volumeCollider()
        {
            return volumeCollider;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other != null && other.CompareTag("Player"))
            {
                // Apply environment volume profile
                if (profile != null)
                {
                    // Profile application logic would go here
                }
            }
        }
    }
}