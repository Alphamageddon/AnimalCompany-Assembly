// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public class RandomizeEnabled : MonoBehaviour, ITileRandomizer
    {
        [Range(0, 1)]
        [Tooltip("1 = 100%")]
        public float chance = 0.5f;

        public RandomizeEnabled()
        {
        }

        public void Render()
        {
            GameObject gameObject = this.gameObject;
            float randomValue = Random.value;
            
            if (gameObject != null)
            {
                bool shouldEnable = randomValue <= chance;
                gameObject.SetActive(shouldEnable);
            }
        }
    }
}