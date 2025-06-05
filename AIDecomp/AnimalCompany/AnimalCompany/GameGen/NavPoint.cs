// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany.GameGen
{
    [RequireComponent(typeof(SphereCollider))]
    public class NavPoint : MonoBehaviour
    {
        public bool respawnable = true;
        
        [Tooltip("When spawning mobs, they will be placed within this radius of the nav point.")]
        public float respawnableRadius = 0.75f;
        
        [HideInInspector]
        public Vector3 position;

        public NavPoint()
        {
        }

        public Vector3 GetSpawnPosition()
        {
            Vector3 randomOffset = Random.insideUnitSphere * respawnableRadius;
            Vector3 basePosition = transform.position;
            return basePosition + randomOffset;
        }

        private void OnDrawGizmos()
        {
            // Set gizmo color to yellow
            Gizmos.color = Color.yellow;
            
            // Draw line from transform position to stored position
            Vector3 transformPos = transform.position;
            Gizmos.DrawLine(transformPos, position);
            
            // Set gizmo color to cyan
            Gizmos.color = Color.cyan;
            
            // Draw wire sphere at transform position with respawnable radius
            Gizmos.DrawWireSphere(transform.position, respawnableRadius);
        }

        private void OnDrawGizmosSelected()
        {
            // Set gizmo color to yellow
            Gizmos.color = Color.yellow;
            
            // Draw line from transform position to stored position
            Vector3 transformPos = transform.position;
            Gizmos.DrawLine(transformPos, position);
            
            // Set gizmo color based on respawnable state
            Gizmos.color = respawnable ? Color.green : Color.red;
            
            // Draw solid sphere at transform position with respawnable radius
            Gizmos.DrawSphere(transform.position, respawnableRadius);
        }

        private void OnEnable()
        {
            position = transform.position;
        }
    }
}