// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace AnimalCompany.GameGen
{
    public class GeneratorComponent : MonoBehaviour
    {
        private const int MAX_ATTEMPTS = 64;
        
        [Tooltip("What id do zones generated from this component start at? It's important that there are not 2 of the same zone id's")]
        public int navZoneOffset;
        
        [SerializeField]
        public List<NavZone> navZoneOutput;
        
        public GenGraph graph;
        public Socket socket;
        public List<Bounds> bounds;
        public Transform itemOutput;
        public Transform mobOutput;
        public NavMeshSurface navSurface;

        public GeneratorComponent()
        {
        }

        [ContextMenu("Generate")]
        public void Generate()
        {
            // Clear existing children
            Transform transform = this.transform;
            if (transform != null)
            {
                for (int i = transform.childCount - 1; i >= 0; i--)
                {
                    GameObject child = transform.GetChild(i).gameObject;
                    DestroyImmediate(child);
                }
            }

            if (itemOutput == null || mobOutput == null)
            {
                Debug.LogError("Item output or mob output is null", this);
                return;
            }

            // Generate using the graph and socket
            Generator generator = new Generator(graph);
            int attempts = 0;
            int seed = Random.Range(0, 100000);
            
            bool success = false;
            while (attempts < MAX_ATTEMPTS && !success)
            {
                success = generator.Generate(graph, socket, seed, navZoneOffset, true, true);
                
                if (!success)
                {
                    // Clear failed generation
                    transform = this.transform;
                    if (transform != null)
                    {
                        for (int i = transform.childCount - 1; i >= 0; i--)
                        {
                            GameObject child = transform.GetChild(i).gameObject;
                            DestroyImmediate(child);
                        }
                    }
                    
                    attempts++;
                    Debug.LogError($"Generation attempt {attempts} failed", this);
                }
            }

            if (success)
            {
                Debug.Log($"Generation succeeded after {attempts} attempts", this);
                
                // Set up outputs
                navZoneOutput = generator.navZones;
                
                // Parent generated content
                if (itemOutput != null && generator.itemParent != null)
                {
                    generator.itemParent.SetParent(itemOutput);
                }
                
                if (mobOutput != null && generator.mobParent != null)
                {
                    generator.mobParent.SetParent(mobOutput);
                }
                
                // Build nav mesh
                if (navSurface != null)
                {
                    navSurface.BuildNavMesh();
                }
            }
        }

        private void OnEnable()
        {
            if (navZoneOutput != null)
            {
                GlobalNavZones.RegisterZones(navZoneOutput);
            }
        }

        private void OnDisable()
        {
            if (navZoneOutput != null)
            {
                GlobalNavZones.DeregisterZones(navZoneOutput);
            }
        }

        private void OnDrawGizmosSelected()
        {
            if (bounds != null)
            {
                Gizmos.color = new Color(1f, 0f, 0f, 1f);
                
                foreach (Bounds bound in bounds)
                {
                    Vector3 size = bound.size;
                    size.x *= 2f;
                    size.y *= 2f;
                    size.z *= 2f;
                    Gizmos.DrawWireCube(bound.center, size);
                }
            }
        }
    }
}