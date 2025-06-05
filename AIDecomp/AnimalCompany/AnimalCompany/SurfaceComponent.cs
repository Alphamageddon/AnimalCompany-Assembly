// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    [ExecuteInEditMode]
    public class SurfaceComponent : MonoBehaviour
    {
        public SurfaceDefinition surfaceDefinition;

        public SurfaceComponent()
        {
        }

        public void ApplySurface()
        {
            if (surfaceDefinition == null)
                return;

            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null && surfaceDefinition != null)
            {
                renderer.sharedMaterial = surfaceDefinition.material;
            }
        }

        private void OnDisable()
        {
        }

        private void OnDrawGizmos()
        {
            if (surfaceDefinition != null)
            {
                Gizmos.color = surfaceDefinition.gizmoColor;
                
                Transform transform = GetComponent<Transform>();
                if (transform != null)
                {
                    Gizmos.matrix = transform.localToWorldMatrix;
                    
                    MeshFilter meshFilter = GetComponent<MeshFilter>();
                    if (meshFilter != null && meshFilter.sharedMesh != null)
                    {
                        Gizmos.DrawMesh(meshFilter.sharedMesh, 
                            surfaceDefinition.gizmoPosition, 
                            surfaceDefinition.gizmoRotation);
                    }
                }
            }
        }

        private void OnEnable()
        {
        }

        private void OnValidate()
        {
        }
    }
}