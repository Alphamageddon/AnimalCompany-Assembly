using UnityEngine;

namespace AnimalCompany
{
    [CreateAssetMenu(fileName = "SurfaceDefinition", menuName = "Surface")]
    public class SurfaceDefinition : ScriptableObject
    {
        [Header("Movement")]
        public float friction = 1f;
        
        [Header("Feedback")]
        [Space]
        public RandomSFX footstepSFX;
        
        [Header("Touch Effects")]
        [Space]
        [Tooltip("Damage dealt to the player when their hands touch the surface. Damage is applied once per touch.")]
        public int damageOnPlayerTouch;
        
        public bool vfxOnTouch;
        public NetworkVFXType touchVFX;
        
        [Header("Debug")]
        [Space]
        public Color debugColor = Color.white;

        public SurfaceDefinition()
        {
        }

        private void OnValidate()
        {
            if (footstepSFX != null)
            {
                // Validation logic for footstep SFX
            }
        }
    }
}