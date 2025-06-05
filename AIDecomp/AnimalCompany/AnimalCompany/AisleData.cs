// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public struct AisleData
    {
        public Vector3 center;
        public Vector3 direction;
        public Vector3[] endPoints;
        public Vector3[] stayPoints;

        public AisleData(Vector3 center, Vector3 direction, Vector3[] endPoints, float stayOffset)
        {
            this.center = center;
            this.direction = direction;
            this.endPoints = endPoints;
            
            if (endPoints != null && endPoints.Length > 0)
            {
                this.stayPoints = new Vector3[endPoints.Length];
                
                Vector3 normalizedDirection = direction.normalized;
                Vector3 offsetVector = normalizedDirection * stayOffset;
                
                for (int i = 0; i < endPoints.Length; i++)
                {
                    this.stayPoints[i] = endPoints[i] + offsetVector;
                }
            }
            else
            {
                this.stayPoints = new Vector3[0];
            }
        }
    }
}