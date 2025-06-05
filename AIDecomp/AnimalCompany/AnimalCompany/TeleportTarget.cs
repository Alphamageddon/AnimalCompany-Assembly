// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany
{
    public class TeleportTarget : MonoBehaviour
    {
        public static Dictionary<TeleTarget, Transform> teleportTargets;
        public TeleTarget target;

        static TeleportTarget()
        {
            teleportTargets = new Dictionary<TeleTarget, Transform>();
        }

        public TeleportTarget()
        {
        }

        private void Awake()
        {
            if (teleportTargets == null)
            {
                teleportTargets = new Dictionary<TeleTarget, Transform>();
            }

            if (teleportTargets.ContainsKey(target))
            {
                Debug.LogWarning($"Teleport target {target} already exists!");
                return;
            }

            teleportTargets.Add(target, transform);
        }

        private void OnDestroy()
        {
            if (teleportTargets != null && teleportTargets.ContainsKey(target))
            {
                teleportTargets.Remove(target);
            }
        }

        public static bool TryGetTeleportTarget(TeleTarget target, out Transform transform)
        {
            if (teleportTargets == null)
            {
                teleportTargets = new Dictionary<TeleTarget, Transform>();
            }

            return teleportTargets.TryGetValue(target, out transform);
        }
    }
}