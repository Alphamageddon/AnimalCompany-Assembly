// Decompiled with Xera AI Decompiler
using UnityEngine;
using Unity.Netcode;

namespace AnimalCompany
{
    [NetworkBehaviourWeaved(0)]
    public class Crowbar : NetworkBehaviour
    {
        private const int HIT_DAMAGE = 15;
        private const float MULTI_HIT_DEBOUNCE = 0.5f;
        
        [SerializeField]
        private RandomSFX hitSFX;
        
        private Rigidbody _rigidbody;
        private GrabbableItem _grabbable;
        private float _lastHitTime;

        public Crowbar()
        {
        }

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _grabbable = GetComponent<GrabbableItem>();
        }

        [WeaverGenerated]
        public virtual void CopyBackingFieldsToState(bool param_0)
        {
        }

        [WeaverGenerated]
        public virtual void CopyStateToBackingFields()
        {
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (!NetworkObject || !NetworkObject.HasStateAuthority)
                return;

            if (Time.time - _lastHitTime < MULTI_HIT_DEBOUNCE)
                return;

            var contacts = collision.contacts;
            if (contacts == null || contacts.Length == 0)
                return;

            var hitPoint = contacts[0].point;
            var hitGameObject = collision.gameObject;
            
            if (hitGameObject == null)
                return;

            var netPlayer = hitGameObject.GetComponent<NetPlayer>();
            if (netPlayer != null && !netPlayer.IsMine)
            {
                var relativeVelocity = collision.relativeVelocity;
                var velocityMagnitude = relativeVelocity.sqrMagnitude;
                
                if (velocityMagnitude > 50f && _rigidbody != null && _grabbable != null)
                {
                    var mass = _rigidbody.mass;
                    var playerController = _grabbable.playerHeldBy;
                    
                    if (playerController != null)
                    {
                        var hitDirection = relativeVelocity.normalized * mass;
                        netPlayer.Hit(HIT_DAMAGE, hitPoint, hitDirection, playerController);
                    }
                }
            }

            var hitRigidbody = collision.rigidbody;
            if (hitRigidbody != null)
            {
                var relativeVelocity = collision.relativeVelocity;
                var force = relativeVelocity * 20f;
                hitRigidbody.AddForceAtPosition(force, hitPoint);
                
                var velocityMagnitude = relativeVelocity.sqrMagnitude;
                var volume = Mathf.Min(velocityMagnitude / 200f, 1f);
                
                if (hitSFX != null)
                {
                    SFXManager.PlaySFXAsRPC(hitSFX, hitPoint, volume);
                }
            }

            _lastHitTime = Time.fixedTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!NetworkObject || !NetworkObject.HasStateAuthority)
                return;

            if (Time.time - _lastHitTime < MULTI_HIT_DEBOUNCE)
                return;

            var netPlayer = other.GetComponent<NetPlayer>();
            if (netPlayer != null && !netPlayer.IsMine && _rigidbody != null && _grabbable != null)
            {
                var hitPoint = transform.position;
                var velocity = _rigidbody.velocity;
                var mass = _rigidbody.mass;
                var playerController = _grabbable.playerHeldBy;
                
                if (playerController != null)
                {
                    var hitDirection = velocity.normalized * mass * 0.5f;
                    netPlayer.Hit(HIT_DAMAGE, hitPoint, hitDirection, playerController);
                    
                    var velocityMagnitude = velocity.sqrMagnitude;
                    var volume = Mathf.Min(velocityMagnitude / 100f, 1f);
                    
                    if (hitSFX != null)
                    {
                        SFXManager.PlaySFXAsRPC(hitSFX, hitPoint, volume);
                    }
                }
            }

            _lastHitTime = Time.fixedTime;
        }
    }
}