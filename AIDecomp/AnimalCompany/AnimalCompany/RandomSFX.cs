using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany
{
    [CreateAssetMenu(fileName = "RandomSFX", menuName = "RandomSFX")]
    public class RandomSFX : ScriptableObject
    {
        public List<AudioClip> audioClips;
        public float volume = 1f;
        public Vector2 pitchRange = new Vector2(1f, 1f);
        public AudioRolloffMode rolloffMode;
        public float falloffDistance = 30f;

        public RandomSFX()
        {
            audioClips = new List<AudioClip>();
            volume = 1f;
            pitchRange = new Vector2(1f, 1f);
            rolloffMode = AudioRolloffMode.Logarithmic;
            falloffDistance = 30f;
        }

        public AudioClip GetRandomClip()
        {
            if (audioClips == null || audioClips.Count == 0)
                return null;

            int randomIndex = Random.Range(0, audioClips.Count);
            return audioClips[randomIndex];
        }

        public void Play(Vector3 position, float volume, SFXPlayMode playMode = SFXPlayMode.Local)
        {
            if (playMode == SFXPlayMode.RPC)
            {
                SFXManager.PlaySFXAsRPC(this, position, volume);
            }
            else
            {
                SFXManager.PlaySFX(this, position, volume);
            }
        }
    }
}