// Decompiled with Xera AI Decompiler
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AnimalCompany
{
    [CreateAssetMenu(fileName = "MobSpawnData", menuName = "AnimalCompany/MobSpawnData", order = 1)]
    public class MobSpawnData : ScriptableObject
    {
        [System.Serializable]
        internal class MobData
        {
            public GameObject prefab;
            public int weight;

            public MobData()
            {
            }
        }

        public int mobSpawnCount;
        public int landMineSpawnCount;
        public MobData[] mobDatas;
        public GameObject landMinePrefab;

        public MobSpawnData()
        {
        }

        public List<GameObject> GetMobsToSpawn()
        {
            return GetMobsToSpawn(mobSpawnCount);
        }

        public List<GameObject> GetMobsToSpawn(int count)
        {
            List<GameObject> result = new List<GameObject>();
            
            if (mobDatas == null || mobDatas.Length == 0)
                return result;

            int totalWeight = mobDatas.Sum(mobData => mobData.weight);
            
            for (int i = 0; i < count; i++)
            {
                int randomValue = UnityEngine.Random.Range(0, totalWeight + 1);
                int currentWeight = 0;
                
                foreach (var mobData in mobDatas)
                {
                    currentWeight += mobData.weight;
                    if (randomValue <= currentWeight)
                    {
                        result.Add(mobData.prefab);
                        break;
                    }
                }
            }
            
            return result;
        }

        public List<GameObject> GetMobsToSpawnGuaranteeEveryMonster(int count)
        {
            List<GameObject> result = new List<GameObject>();
            
            if (mobDatas == null || mobDatas.Length == 0)
                return result;

            // First, add one of each mob type
            foreach (var mobData in mobDatas)
            {
                result.Add(mobData.prefab);
            }

            // Fill remaining slots with weighted random selection
            int remainingCount = count - mobDatas.Length;
            if (remainingCount > 0)
            {
                int totalWeight = mobDatas.Sum(mob => mob.weight);
                
                for (int i = 0; i < remainingCount; i++)
                {
                    int randomValue = UnityEngine.Random.Range(0, totalWeight + 1);
                    int currentWeight = 0;
                    
                    foreach (var mobData in mobDatas)
                    {
                        currentWeight += mobData.weight;
                        if (randomValue <= currentWeight)
                        {
                            result.Add(mobData.prefab);
                            break;
                        }
                    }
                }
            }
            
            return result;
        }
    }
}