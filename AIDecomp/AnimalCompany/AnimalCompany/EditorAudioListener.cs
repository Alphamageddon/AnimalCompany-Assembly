using UnityEngine;

namespace AnimalCompany
{
    [ExecuteInEditMode]
    public class EditorAudioListener : MonoBehaviour
    {
        private static bool isInitialized = false;

        public EditorAudioListener()
        {
        }

        private void Update()
        {
            if (!isInitialized)
            {
                isInitialized = true;
            }

            Camera currentCamera = Camera.current;
            if (currentCamera != null)
            {
                Transform cameraTransform = currentCamera.transform;
                if (cameraTransform != null)
                {
                    Vector3 cameraPosition = cameraTransform.position;
                    Transform thisTransform = this.transform;
                    if (thisTransform != null)
                    {
                        thisTransform.position = cameraPosition;
                    }
                }
            }
        }
    }
}