// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany.PrototypeOne
{
    public class MobView : MonoBehaviour
    {
        private static readonly int ANIM_BOOL_ISWALK;
        private static readonly int ANIM_FLOAT_SPEED;
        
        [SerializeField]
        private Animator _animator;
        [SerializeField]
        private AudioSource _audioSourceNotice;
        [SerializeField]
        private AudioSource _audioSourceWalk;
        [SerializeField]
        private AudioClip _audioNotice;
        [SerializeField]
        private AudioClip _audioWalk;
        [SerializeField]
        private AudioClip _audioRun;

        public bool isWalking
        {
            get
            {
                if (_animator == null)
                    return false;
                return _animator.GetBool(ANIM_BOOL_ISWALK);
            }
        }

        static MobView()
        {
            ANIM_BOOL_ISWALK = Animator.StringToHash("IsWalk");
            ANIM_FLOAT_SPEED = Animator.StringToHash("Speed");
        }

        public MobView()
        {
        }

        public bool get_isWalking()
        {
            return isWalking;
        }

        public bool IsSoundRunPlaying()
        {
            if (_audioSourceWalk == null)
                return false;
            
            AudioClip currentClip = _audioSourceWalk.clip;
            bool hasClip = currentClip != null;
            bool isPlaying = _audioSourceWalk.isPlaying;
            
            return hasClip && isPlaying;
        }

        public void PlaySound(AudioClip clip)
        {
            if (_audioSourceWalk == null)
                return;

            AudioClip currentClip = _audioSourceWalk.clip;
            if (currentClip != clip)
            {
                if (_audioSourceWalk.isPlaying)
                {
                    _audioSourceWalk.Stop();
                }
            }

            if (_audioSourceWalk.isPlaying)
                return;

            _audioSourceWalk.PlayOneShot(clip);
        }

        public void PlaySoundNotice()
        {
            if (_audioSourceNotice == null)
                return;

            if (_audioSourceNotice.isPlaying)
                return;

            if (_audioNotice != null)
            {
                _audioSourceNotice.PlayOneShot(_audioNotice);
            }
        }

        public void PlaySoundRun()
        {
            PlaySound(_audioRun);
        }

        public void PlaySoundWalk()
        {
            PlaySound(_audioWalk);
        }

        public void SetWalk(bool isWalking)
        {
            if (_animator == null)
                return;
            
            _animator.SetBool(ANIM_BOOL_ISWALK, isWalking);
        }

        public void SetWalkSpeed(float speed)
        {
            if (_animator == null)
                return;
            
            _animator.SetFloat(ANIM_FLOAT_SPEED, speed);
        }

        public void StopSoundWalk()
        {
            if (_audioSourceWalk != null)
            {
                _audioSourceWalk.Stop();
            }
        }
    }
}