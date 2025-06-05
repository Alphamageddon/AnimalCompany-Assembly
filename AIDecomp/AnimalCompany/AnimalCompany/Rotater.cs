using UnityEngine;

namespace AnimalCompany
{
    public class Rotater : MonoBehaviour
    {
        public Vector3 rotationSpeed;

        public Rotater()
        {
        }

        private void Update()
        {
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }
    }
}