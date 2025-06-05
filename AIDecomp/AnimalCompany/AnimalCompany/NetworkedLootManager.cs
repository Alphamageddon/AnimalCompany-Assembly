// Decompiled with Xera AI Decompiler
using Fusion;
using System;
using UnityEngine;

namespace AnimalCompany
{
    [NetworkBehaviourWeaved(0)]
    public class NetworkedLootManager : NetworkBehaviour
    {
        [System.Runtime.CompilerServices.CompilerGenerated]
        private sealed class <>c__DisplayClass3_0
        {
            public LootSpawnGroup spawnGroup;

            public <>c__DisplayClass3_0() { }

            internal void <Spawned>b__0(NetworkRunner runner, NetworkObject obj) { }
        }

        [SerializeField]
        private NetworkedLootSpawnGroup _networkedLootSpawnPrefab;
        private LootSpawnGroup[] _lootSpawnGroups;

        public NetworkedLootManager() { }

        private void Awake()
        {
            _lootSpawnGroups = FindObjectsOfType<LootSpawnGroup>();
        }

        [WeaverGenerated]
        public virtual void CopyBackingFieldsToState(bool param_0) { }

        [WeaverGenerated]
        public virtual void CopyStateToBackingFields() { }

        public virtual void Spawned()
        {
            base.Spawned();

            if (Object != null && !Object.IsProxy && Object.HasStateAuthority)
            {
                if (_lootSpawnGroups != null)
                {
                    for (int i = 0; i < _lootSpawnGroups.Length; i++)
                    {
                        var spawnGroup = _lootSpawnGroups[i];
                        if (spawnGroup != null)
                        {
                            var displayClass = new <>c__DisplayClass3_0();
                            displayClass.spawnGroup = spawnGroup;

                            var spawnPosition = spawnGroup.transform.position;
                            var spawnRotation = spawnGroup.transform.rotation;

                            Runner.Spawn(
                                _networkedLootSpawnPrefab,
                                spawnGroup.gameObject,
                                spawnPosition,
                                spawnRotation,
                                null,
                                null,
                                displayClass.<Spawned>b__0
                            );
                        }
                    }
                }
            }
        }
    }
}