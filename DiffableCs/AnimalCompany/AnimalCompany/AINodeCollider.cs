namespace AnimalCompany;

public class AINodeCollider : MonoBehaviour
{
        public int id; //Field offset: 0x20

        public AINodeCollider() { }

        private void OnDrawGizmos()
        {
                Gizmos.color = Color.green;
                Gizmos.DrawSphere(transform.position, 0.05f);
        }

        public void Setup(int id)
        {
                this.id = id;
        }

}

