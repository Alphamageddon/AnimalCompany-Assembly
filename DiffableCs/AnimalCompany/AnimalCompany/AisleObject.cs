namespace AnimalCompany;

public class AisleObject : MonoBehaviour
{
	internal enum Direction
	{
		forward = 0,
		right = 1,
		up = 2,
	}

	[SerializeField]
	private Direction _direction; //Field offset: 0x20
	[SerializeField]
	private Vector3 _centerOffset; //Field offset: 0x24
        [SerializeField]
        private float _length; //Field offset: 0x30

        public Vector3 center
        {
                 get
                 {
                        return transform.position + transform.TransformDirection(_centerOffset);
                 }
        }

        public Vector3 direction
        {
                 get
                 {
                        return _direction switch
                        {
                                Direction.forward => transform.forward,
                                Direction.right => transform.right,
                                Direction.up => transform.up,
                                _ => Vector3.forward,
                        };
                 }
        }

        public Vector3[] endPoints
        {
                 get
                 {
                        Vector3 dir = direction.normalized * _length * 0.5f;
                        Vector3 c = center;
                        return new Vector3[] { c - dir, c + dir };
                 }
        }

        public AisleObject() { }

        public Vector3 get_center() => center;

        public Vector3 get_direction() => direction;

        public Vector3[] get_endPoints() => endPoints;

        public AisleData GetAisleData(float stayOffset)
        {
                return new AisleData(center, direction, endPoints, stayOffset);
        }

        private void OnDrawGizmosSelected()
        {
                Vector3[] pts = endPoints;
                if (pts == null || pts.Length < 2)
                        return;

                Gizmos.color = Color.cyan;
                Gizmos.DrawLine(pts[0], pts[1]);
        }

}

