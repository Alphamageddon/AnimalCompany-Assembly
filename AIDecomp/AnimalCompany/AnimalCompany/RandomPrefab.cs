// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    [CreateAssetMenu(fileName = "RandomPrefab", menuName = "RandomPrefab")]
    public class RandomPrefab : ScriptableObject
    {
        public GameObject[] prefabs;

        public GameObject prefab
        {
            get
            {
                if (prefabs != null && prefabs.Length > 0)
                {
                    int randomIndex = Random.Range(0, prefabs.Length);
                    return prefabs[randomIndex];
                }
                return null;
            }
        }

        public RandomPrefab()
        {
        }

        public GameObject get_prefab()
        {
            return prefab;
        }
    }
}