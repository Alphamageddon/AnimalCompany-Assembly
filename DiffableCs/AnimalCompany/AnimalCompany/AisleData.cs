namespace AnimalCompany;

public struct AisleData
{
        public Vector3 center; //Field offset: 0x0
        public Vector3 direction; //Field offset: 0xC
        public Vector3[] endPoints; //Field offset: 0x18
        public Vector3[] stayPoints; //Field offset: 0x20

        public AisleData(Vector3 center, Vector3 direction, Vector3[] endPoints, float stayOffset)
        {
                this.center = center;
                this.direction = direction.normalized;
                this.endPoints = endPoints;

                if (endPoints == null || endPoints.Length == 0)
                {
                        stayPoints = System.Array.Empty<Vector3>();
                        return;
                }

                stayPoints = new Vector3[endPoints.Length];
                for (int i = 0; i < endPoints.Length; i++)
                {
                        stayPoints[i] = Vector3.Lerp(center, endPoints[i], stayOffset);
                }
        }

}

