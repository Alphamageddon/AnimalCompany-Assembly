// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class ComponentHelpers : MonoBehaviour
    {
        public ComponentHelpers()
        {
        }

        [ContextMenu("SetMeshColliderConvex")]
        public void SetMeshColliderConvex()
        {
            MeshCollider[] meshColliders = GetComponentsInChildren<MeshCollider>();
            
            for (int i = 0; i < meshColliders.Length; i++)
            {
                MeshCollider meshCollider = meshColliders[i];
                if (meshCollider != null)
                {
                    meshCollider.convex = true;
                }
            }
        }
    }
}