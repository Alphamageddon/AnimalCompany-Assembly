using UnityEngine;

namespace AnimalCompany
{
    public class PlayerAudioView : MonoBehaviour
    {
        private static readonly Vector2 HAND_STEP_SOUND_MIN_MAX = new Vector2(0.8f, 1.2f);
        
        [SerializeField]
        private AudioClip[] _audioClipsFootStep;
        
        [SerializeField]
        private AudioSource _audioSourceFootStepLeft;
        
        [SerializeField]
        private AudioSource _audioSourceFootStepRight;

        public int handStepClipCount
        {
            get
            {
                if (_audioClipsFootStep == null)
                    return 0;
                return _audioClipsFootStep.Length;
            }
        }

        static PlayerAudioView()
        {
            HAND_STEP_SOUND_MIN_MAX = new Vector2(0.8f, 1.2f);
        }

        public PlayerAudioView()
        {
        }

        public int get_handStepClipCount()
        {
            return handStepClipCount;
        }

        public void PlayHandstepSound(HandSide handSide, int clipIndex, float intensity01)
        {
            if (_audioClipsFootStep == null || _audioClipsFootStep.Length == 0)
                return;

            AudioSource audioSource = handSide == HandSide.Left ? _audioSourceFootStepLeft : _audioSourceFootStepRight;
            
            if (audioSource == null)
                return;

            clipIndex = Random.Range(0, _audioClipsFootStep.Length);
            
            if (clipIndex >= _audioClipsFootStep.Length)
                return;

            AudioClip clip = _audioClipsFootStep[clipIndex];
            if (clip == null)
                return;

            audioSource.clip = clip;
            
            intensity01 = Mathf.Clamp01(intensity01);
            float volume = Mathf.Lerp(HAND_STEP_SOUND_MIN_MAX.x, HAND_STEP_SOUND_MIN_MAX.y, intensity01);
            audioSource.volume = volume;
            
            audioSource.Play();
        }
    }
}