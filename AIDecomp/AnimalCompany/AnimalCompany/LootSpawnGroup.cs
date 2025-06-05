// Decompiled with Xera AI Decompiler
using System;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany
{
    public class LootSpawnGroup : MonoBehaviour
    {
        private static Dictionary<short, LootSpawnGroup> _spawnGroupLookup;
        
        public float valueToSpawn;
        public List<WeightedConnectionItemPoints> pointsWeightedByConnection;
        public int totalConnectionWeight;
        public List<WeightedItem> weightedItems;
        public float totalItemWeight;
        
        [SerializeField]
        private short _id;

        public short id
        {
            get { return _id; }
        }

        static LootSpawnGroup()
        {
            _spawnGroupLookup = new Dictionary<short, LootSpawnGroup>();
        }

        public LootSpawnGroup()
        {
        }

        private void Awake()
        {
            if (_spawnGroupLookup == null)
                _spawnGroupLookup = new Dictionary<short, LootSpawnGroup>();

            if (_spawnGroupLookup.ContainsKey(_id))
            {
                Debug.LogError($"Duplicate LootSpawnGroup ID: {_id}");
            }
            else
            {
                _spawnGroupLookup[_id] = this;
            }
        }

        protected void OnValidate()
        {
            if (!Application.isPlaying)
            {
                HashSet<short> usedIds = new HashSet<short>();
                
                if (pointsWeightedByConnection != null)
                {
                    foreach (var point in pointsWeightedByConnection)
                    {
                        if (point != this && point != null)
                        {
                            usedIds.Add(point.id);
                        }
                    }
                }

                if (usedIds.Contains(_id))
                {
                    _id = (short)Guid.NewGuid().GetHashCode();
                }
            }
        }

        public static bool TryGetSpawnGroup(short id, out LootSpawnGroup spawnGroup)
        {
            if (_spawnGroupLookup == null)
            {
                spawnGroup = null;
                return false;
            }

            return _spawnGroupLookup.TryGetValue(id, out spawnGroup);
        }
    }
}