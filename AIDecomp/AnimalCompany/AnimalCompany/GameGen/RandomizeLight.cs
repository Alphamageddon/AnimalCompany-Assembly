// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public class RandomizeLight : MonoBehaviour, ITileRandomizer
    {
        public Vector2 intensity;

        public RandomizeLight()
        {
            intensity = Vector2.zero;
        }

        public void Render()
        {
            Light lightComponent = GetComponent<Light>();
            
            if (lightComponent == null)
            {
                Debug.LogWarning("No Light component found on " + gameObject.name);
                return;
            }

            float randomIntensity = Random.Range(intensity.x, intensity.y);
            lightComponent.intensity = randomIntensity;
        }
    }
}