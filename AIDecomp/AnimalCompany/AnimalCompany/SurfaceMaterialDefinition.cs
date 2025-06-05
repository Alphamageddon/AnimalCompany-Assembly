using UnityEngine;

namespace AnimalCompany
{
    [CreateAssetMenu(fileName = "SurfaceDefinition", menuName = "Surface + Material")]
    public class SurfaceMaterialDefinition : SurfaceDefinition
    {
        [Header("Surface Material Settings")]
        [Space(10)]
        public Material material;

        public SurfaceMaterialDefinition()
        {
        }

        private void OnValidate()
        {
            if (Application.isPlaying)
            {
                SurfaceEditorManager.UpdateSurfaceComponents();
            }
        }
    }
}