// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class HelperApplyMaterial : MonoBehaviour
    {
        public GameObject root;
        public Material[] materials;

        public HelperApplyMaterial()
        {
        }

        [ContextMenu("Apply Materials")]
        public void ApplyMaterials()
        {
            if (root == null) return;

            Renderer[] renderers = root.GetComponentsInChildren<Renderer>();
            if (renderers == null) return;

            for (int i = 0; i < renderers.Length; i++)
            {
                if (renderers[i] != null)
                {
                    renderers[i].materials = materials;
                }
            }
        }
    }
}