// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    [ExecuteAlways]
    public class PlanarDistanceCull : MonoBehaviour
    {
        public MeshRenderer meshRenderer;
        
        [Tooltip("The renderer will be visible if the SQR distance is less than this.")]
        public float sqrDistanceVisible = 100f;
        
        private Plane plane;

        public PlanarDistanceCull()
        {
        }

        private void OnEnable()
        {
            if (transform != null)
            {
                Vector3 forward = transform.forward;
                Vector3 position = transform.position;
                plane = new Plane(forward, position);
            }
        }

        private void Update()
        {
            Camera mainCamera = Camera.main;
            if (mainCamera == null || mainCamera.transform == null || meshRenderer == null)
                return;

            Vector3 cameraPosition = mainCamera.transform.position;
            float distanceToPlane = plane.GetDistanceToPoint(cameraPosition);
            Vector3 closestPointOnPlane = cameraPosition - plane.normal * distanceToPlane;
            
            float sqrDistance = (cameraPosition - closestPointOnPlane).sqrMagnitude;
            
            meshRenderer.enabled = sqrDistance <= sqrDistanceVisible;
        }
    }
}