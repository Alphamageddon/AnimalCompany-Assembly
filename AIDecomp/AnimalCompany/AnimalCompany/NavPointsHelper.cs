// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class NavPointsHelper : MonoBehaviour
    {
        public int zoneId;
        public Vector3 direction;
        public Vector3 directionPoint;

        public NavPointsHelper()
        {
            direction = Vector3.up;
            directionPoint = Vector3.zero;
        }

        [ContextMenu("ApplyLayer")]
        public void ApplyLayer()
        {
            NavPoint[] navPoints = GetNavPoints();
            if (navPoints == null) return;

            for (int i = 0; i < navPoints.Length; i++)
            {
                if (navPoints[i] != null)
                {
                    GameObject gameObject = navPoints[i].gameObject;
                    if (gameObject != null)
                    {
                        gameObject.layer = 15;
                    }
                }
            }
        }

        [ContextMenu("ApplyRotaionTowardsPoint")]
        public void ApplyRotaionTowardsPoint()
        {
            NavPoint[] navPoints = GetNavPoints();
            if (navPoints == null) return;

            for (int i = 0; i < navPoints.Length; i++)
            {
                NavPoint navPoint = navPoints[i];
                if (navPoint != null)
                {
                    Transform navTransform = navPoint.transform;
                    if (navTransform != null)
                    {
                        Vector3 flattenedDirection = Extensions.Flatten(directionPoint);
                        Vector3 flattenedPosition = Extensions.Flatten(navTransform.position);
                        Vector3 lookDirection = flattenedDirection - flattenedPosition;
                        
                        Quaternion rotation = Quaternion.LookRotation(lookDirection);
                        navTransform.rotation = rotation;
                    }
                }
            }
        }

        [ContextMenu("ApplyRotation")]
        public void ApplyRotation()
        {
            NavPoint[] navPoints = GetNavPoints();
            if (navPoints == null) return;

            for (int i = 0; i < navPoints.Length; i++)
            {
                if (navPoints[i] != null)
                {
                    Transform navTransform = navPoints[i].transform;
                    if (navTransform != null)
                    {
                        Quaternion rotation = Quaternion.LookRotation(direction);
                        navTransform.rotation = rotation;
                    }
                }
            }
        }

        private NavPoint[] GetNavPoints()
        {
            return FindObjectsOfType<NavPoint>();
        }

        [ContextMenu("StickToGround")]
        public void StickToGround()
        {
            NavPoint[] navPoints = GetNavPoints();
            if (navPoints == null) return;

            LayerMask groundLayer = LayerMask.GetMask("Ground");
            
            for (int i = 0; i < navPoints.Length; i++)
            {
                NavPoint navPoint = navPoints[i];
                if (navPoint != null)
                {
                    Transform navTransform = navPoint.transform;
                    if (navTransform != null)
                    {
                        Vector3 position = navTransform.position;
                        Vector3 rayOrigin = position + Vector3.up * 0.5f;
                        
                        if (Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, Mathf.Infinity, groundLayer))
                        {
                            Vector3 groundPosition = hit.point;
                            Vector3 offset = Vector3.up * 0.1f;
                            navTransform.position = groundPosition + offset;
                        }
                    }
                }
            }
        }
    }
}