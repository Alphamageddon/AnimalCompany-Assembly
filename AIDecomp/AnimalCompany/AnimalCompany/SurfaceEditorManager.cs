using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany
{
    public static class SurfaceEditorManager
    {
        private static List<SurfaceComponent> surfaceComponents;
        private static readonly float UPDATE_INTERVAL = 5.0f;
        private static int lastFrame;
        private static double lastUpdateTime;

        static SurfaceEditorManager()
        {
            surfaceComponents = new List<SurfaceComponent>();
        }

        public static void AddSurfaceComponent(SurfaceComponent surfaceComponent)
        {
            if (surfaceComponents == null)
                surfaceComponents = new List<SurfaceComponent>();
            
            surfaceComponents.Add(surfaceComponent);
        }

        public static void RemoveSurfaceComponent(SurfaceComponent surfaceComponent)
        {
            if (surfaceComponents == null)
                return;
                
            surfaceComponents.Remove(surfaceComponent);
        }

        public static void UpdateSurfaceComponents()
        {
            if (surfaceComponents == null)
                return;

            int currentFrame = Time.frameCount;
            double currentTime = Time.realtimeSinceStartupAsDouble;

            if (currentFrame != lastFrame && (currentTime - lastUpdateTime) >= UPDATE_INTERVAL)
            {
                lastFrame = currentFrame;
                lastUpdateTime = currentTime;

                foreach (var component in surfaceComponents)
                {
                    if (component != null)
                    {
                        component.ApplySurface();
                    }
                }
            }
        }
    }
}