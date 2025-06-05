using UnityEngine;

namespace AnimalCompany
{
    public class LightByDistance : MonoBehaviour
    {
        public Vector2 range;
        public float intensity;
        public Light lightSource;

        public LightByDistance()
        {
            range = new Vector2(5f, 20f);
            intensity = 5f;
        }

        private void Update()
        {
            Camera mainCamera = Camera.main;
            if (mainCamera == null)
                return;

            Transform cameraTransform = mainCamera.transform;
            if (cameraTransform == null)
                return;

            Transform thisTransform = transform;
            if (thisTransform == null)
                return;

            Vector3 cameraPosition = cameraTransform.position;
            Vector3 thisPosition = thisTransform.position;

            float distance = Vector3.Distance(thisPosition, cameraPosition);
            
            float normalizedDistance = (distance - range.y) / (range.x - range.y);
            normalizedDistance = Mathf.Clamp01(normalizedDistance);
            
            if (lightSource != null)
            {
                float targetIntensity = normalizedDistance * intensity;
                lightSource.intensity = Mathf.Max(0f, targetIntensity);
                lightSource.enabled = lightSource.intensity > 0f;
            }
        }
    }
}