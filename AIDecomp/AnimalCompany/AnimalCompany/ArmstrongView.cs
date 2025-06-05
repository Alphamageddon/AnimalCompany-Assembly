// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class ArmstrongView : MobView
    {
        private bool _isHeadMoving;
        private float _headMovingSpeed;
        private Vector3 _headLookAtLocalPositionCached;

        public ArmstrongView()
        {
            _isHeadMoving = true;
            _headMovingSpeed = 0.2f;
        }

        protected virtual void Awake()
        {
            base.Awake();
            
            if (transform != null)
            {
                _headLookAtLocalPositionCached = transform.localPosition;
            }
        }

        protected virtual void Update()
        {
            base.Update();
            
            if (_isHeadMoving && transform != null)
            {
                float time = Time.time;
                float lerpValue = time * _headMovingSpeed;
                
                Vector3 newPosition = new Vector3(
                    _headLookAtLocalPositionCached.x,
                    _headLookAtLocalPositionCached.y,
                    _headLookAtLocalPositionCached.z
                );
                
                transform.localPosition = Vector3.Lerp(transform.localPosition, newPosition, lerpValue);
            }
        }

        public void SetHeadMoving(bool isHeadMoving, float speed = 0.2f)
        {
            _isHeadMoving = isHeadMoving;
            _headMovingSpeed = speed;
            
            if (!isHeadMoving && transform != null)
            {
                transform.localPosition = _headLookAtLocalPositionCached;
            }
        }

        public void SetHeadLookAtTarget(Vector3 target, Vector3 viewPoint)
        {
            if (transform == null) return;
            
            Vector3 direction = (target - viewPoint).normalized;
            Vector3 worldPosition = transform.position;
            Vector3 targetPosition = worldPosition + direction;
            
            transform.position = targetPosition;
        }
    }
}