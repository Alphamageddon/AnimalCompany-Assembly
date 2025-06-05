using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany
{
    public static class SurfaceAssetCache
    {
        private static Dictionary<string, SurfaceDefinition> surfaceLookupCache;

        static SurfaceAssetCache()
        {
            surfaceLookupCache = new Dictionary<string, SurfaceDefinition>();
        }

        public static void InvalidateCache()
        {
            if (surfaceLookupCache == null)
            {
                surfaceLookupCache = new Dictionary<string, SurfaceDefinition>();
            }
            else
            {
                surfaceLookupCache.Clear();
            }
        }

        public static bool TryGetSurface(string name, out SurfaceDefinition surface)
        {
            surface = null;
            
            if (surfaceLookupCache == null)
            {
                surfaceLookupCache = new Dictionary<string, SurfaceDefinition>();
            }

            if (surfaceLookupCache.TryGetValue(name, out surface))
            {
                return surface != null;
            }

            // Load surface from resources
            surface = Resources.Load<SurfaceDefinition>(name);
            
            if (surface != null)
            {
                surfaceLookupCache[name] = surface;
                return true;
            }

            return false;
        }
    }
}