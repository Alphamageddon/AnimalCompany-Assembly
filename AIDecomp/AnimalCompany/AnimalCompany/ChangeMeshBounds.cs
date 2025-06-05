// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class ChangeMeshBounds : MonoBehaviour
    {
        [SerializeField]
        private MeshFilter _meshFilter;

        public ChangeMeshBounds()
        {
        }

        [ContextMenu("ChangeBounds")]
        public void ChangeBounds()
        {
            if (_meshFilter == null)
                return;

            Mesh sharedMesh = _meshFilter.sharedMesh;
            if (sharedMesh == null)
                return;

            Bounds bounds = sharedMesh.bounds;
            Vector3 center = bounds.center;
            Vector3 size = bounds.size;

            // Modify bounds - appears to be scaling/adjusting the bounds
            float scaleFactor = 0.5f;
            size *= scaleFactor;
            
            Bounds newBounds = new Bounds(center, size);
            sharedMesh.bounds = newBounds;
            
            _meshFilter.sharedMesh = sharedMesh;
        }
    }
}