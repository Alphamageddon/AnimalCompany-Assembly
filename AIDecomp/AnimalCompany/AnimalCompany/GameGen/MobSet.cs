// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany.GameGen
{
    [CreateAssetMenu(fileName = "MobSet", menuName = "GameGen/Mob Set", order = 0)]
    public class MobSet : ScriptableObject
    {
        public List<GameObject> mobs;

        public MobSet()
        {
            mobs = new List<GameObject>();
        }

        public GameObject GetRandomMob()
        {
            if (mobs == null || mobs.Count == 0)
                return null;
            
            int randomIndex = Random.Range(0, mobs.Count);
            return mobs[randomIndex];
        }
    }
}