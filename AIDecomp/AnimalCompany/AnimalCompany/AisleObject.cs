// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class AisleObject : MonoBehaviour
    {
        internal enum Direction
        {
            forward = 0,
            right = 1,
            up = 2,
        }

        [SerializeField]
        private Direction _direction;
        [SerializeField]
        private Vector3 _centerOffset;
        [SerializeField]
        private float _length;

        public Vector3 center
        {
            get
            {
                return transform.position + transform.rotation * _centerOffset;
            }
        }

        public Vector3 direction
        {
            get
            {
                switch (_direction)
                {
                    case Direction.forward:
                        return transform.rotation * Vector3.forward;
                    case Direction.right:
                        return transform.rotation * Vector3.right;
                    case Direction.up:
                        return transform.rotation * Vector3.up;
                    default:
                        return transform.rotation * Vector3.forward;
                }
            }
        }

        public Vector3[] endPoints
        {
            get
            {
                Vector3[] points = new Vector3[2];
                Vector3 centerPos = center;
                Vector3 dir = direction;
                float halfLength = _length * 0.5f;
                
                points[0] = centerPos + dir * halfLength;
                points[1] = centerPos - dir * halfLength;
                
                return points;
            }
        }

        public AisleData GetAisleData(float stayOffset)
        {
            Vector3 centerPos = center;
            Vector3 dir = direction;
            Vector3[] points = endPoints;
            
            return new AisleData(points, centerPos, dir, stayOffset);
        }

        private void OnDrawGizmosSelected()
        {
            Matrix4x4 originalMatrix = Gizmos.matrix;
            
            Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, Vector3.one);
            
            // Draw main cube
            Gizmos.color = Color.white;
            if (_direction == Direction.forward)
            {
                Gizmos.DrawCube(_centerOffset, new Vector3(1f, 1f, _length));
            }
            
            // Draw center sphere
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(Vector3.zero, 0.1f);
            
            Gizmos.matrix = originalMatrix;
            
            // Draw end points
            Vector3[] points = endPoints;
            if (points != null)
            {
                Gizmos.color = Color.red;
                for (int i = 0; i < points.Length; i++)
                {
                    Gizmos.DrawSphere(points[i], 0.1f);
                }
            }
        }

        public AisleObject()
        {
            _length = 10f;
            _centerOffset = Vector3.zero;
        }
    }
}