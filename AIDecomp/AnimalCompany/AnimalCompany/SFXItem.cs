using UnityEngine;

namespace AnimalCompany
{
    [RequireComponent(typeof(GrabbableItem))]
    public class SFXItem : MonoBehaviour
    {
        [SerializeField]
        private RandomSFX _sfx;
        private GrabbableItem _grabbable;
        private float _lastUseTime;

        public SFXItem()
        {
        }

        private void Awake()
        {
            _grabbable = GetComponent<GrabbableItem>();
            if (_grabbable != null)
            {
                _grabbable.OnUse += HandleUse;
            }
        }

        private void HandleUse()
        {
            float currentTime = Time.time;
            if (currentTime - _lastUseTime >= 0.5f)
            {
                if (_sfx != null)
                {
                    Transform transform = this.transform;
                    if (transform != null)
                    {
                        Vector3 position = transform.position;
                        SFXManager.PlaySFXAsRPC(_sfx, position, 1f);
                        _lastUseTime = Time.time;
                    }
                }
            }
        }

        private void OnDestroy()
        {
            if (_grabbable != null)
            {
                _grabbable.OnUse -= HandleUse;
            }
        }
    }
}