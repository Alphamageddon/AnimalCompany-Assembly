using UnityEngine;

namespace AnimalCompany
{
    [RequireComponent(typeof(AudioSource))]
    public class RandomizePitch : MonoBehaviour, ITileRandomizer
    {
        public Vector2 pitch;

        public RandomizePitch()
        {
            pitch = Vector2.zero;
        }

        public override void Render()
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            
            if (audioSource == null)
            {
                Debug.LogWarning($"AudioSource component not found on {gameObject.name}");
                return;
            }

            float randomPitch = Random.Range(pitch.x, pitch.y);
            audioSource.pitch = randomPitch;
        }
    }
}