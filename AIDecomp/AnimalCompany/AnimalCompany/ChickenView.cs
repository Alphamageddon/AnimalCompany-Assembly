using UnityEngine;

namespace AnimalCompany
{
    public class ChickenView : MobView
    {
        [SerializeField]
        private AudioSource _audioSourceRunning;
        [SerializeField]
        private MeshRenderer _rendererTeeth;

        public ChickenView()
        {
        }

        public void PlayRunningSound(bool play, float volume = 1f)
        {
            if (_audioSourceRunning == null)
                return;

            if (play)
            {
                if (!_audioSourceRunning.isPlaying)
                {
                    _audioSourceRunning.Play();
                }
            }
            else
            {
                if (_audioSourceRunning.isPlaying)
                {
                    _audioSourceRunning.Stop();
                }
            }

            _audioSourceRunning.volume = volume;
        }

        public void SetTeethVisible(bool visible)
        {
            if (_rendererTeeth != null)
            {
                _rendererTeeth.enabled = visible;
            }
        }

        protected virtual void Update()
        {
            base.Update();

            if (IsMoving && IsGrounded && PlayerController != null)
            {
                Transform playerTransform = PlayerController.transform;
                if (playerTransform != null)
                {
                    Vector3 playerPosition = playerTransform.position;
                    if (transform != null)
                    {
                        transform.position = playerPosition;
                    }
                }
            }
        }
    }
}