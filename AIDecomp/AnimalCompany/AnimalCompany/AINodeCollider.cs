// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class AINodeCollider : MonoBehaviour
    {
        public int id;

        public AINodeCollider()
        {
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            
            Transform transform = this.transform;
            if (transform != null)
            {
                Gizmos.DrawSphere(transform.position, 0.5f);
            }
        }

        public void Setup(int id)
        {
            this.id = id;
        }
    }
}