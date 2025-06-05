// Decompiled with Xera AI Decompiler
using System;
using System.Collections.Generic;

namespace AnimalCompany.GameGen
{
    public static class GlobalNavZones
    {
        public static Dictionary<int, NavZone> zones;

        static GlobalNavZones()
        {
            zones = new Dictionary<int, NavZone>();
        }

        public static void RegisterZones(List<NavZone> newZones)
        {
            if (newZones == null)
                return;

            foreach (NavZone zone in newZones)
            {
                if (zones.ContainsKey(zone.id))
                {
                    UnityEngine.Debug.LogWarning($"Zone with ID {zone.id} already registered!");
                }
                else
                {
                    zones.Add(zone.id, zone);
                }
            }
        }

        public static void DeregisterZones(List<NavZone> newZones)
        {
            if (newZones == null)
                return;

            foreach (NavZone zone in newZones)
            {
                if (zones.ContainsKey(zone.id))
                {
                    zones.Remove(zone.id);
                }
                
                UnityEngine.Debug.LogWarning($"Deregistering zone {zone.id}");
            }
        }

        public static bool TryGetNavZone(int id, out NavZone zone)
        {
            if (zones != null && zones.ContainsKey(id))
            {
                zone = zones[id];
                return true;
            }
            
            zone = default(NavZone);
            return false;
        }
    }
}