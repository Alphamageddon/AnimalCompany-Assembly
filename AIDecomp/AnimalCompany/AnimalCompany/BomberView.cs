// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class BomberView : MobView
    {
        private static readonly int PROP_EMISSION_COLOR;
        private static readonly int PROP_EMISSION_FRESNEL;
        private static readonly Color EMISSION_COLOR;
        
        [SerializeField]
        private Renderer _renderer;
        private bool _isInExplosion;

        static BomberView()
        {
            PROP_EMISSION_COLOR = Shader.PropertyToID("_EmissionColor");
            PROP_EMISSION_FRESNEL = Shader.PropertyToID("_EmissionFresnel");
            EMISSION_COLOR = new Color(1f, 0.5f, 0f, 1f);
        }

        public BomberView()
        {
        }

        public void SetEmission(bool emission)
        {
            _isInExplosion = emission;
            
            if (_renderer != null)
            {
                Material material = _renderer.material;
                if (material != null)
                {
                    if (emission)
                    {
                        material.SetColor(PROP_EMISSION_COLOR, EMISSION_COLOR);
                    }
                    else
                    {
                        material.SetColor(PROP_EMISSION_COLOR, Color.black);
                    }
                }
            }
        }

        protected virtual void Update()
        {
            base.Update();
            
            if (_isInExplosion && _renderer != null)
            {
                Material[] materials = _renderer.materials;
                if (materials != null && materials.Length > 0)
                {
                    Material material = materials[0];
                    if (material != null)
                    {
                        float time = Time.time;
                        float wave = Mathf.Sin(time * 8f) * 0.5f + 0.5f;
                        float fresnel = 1f - Mathf.Abs(wave);
                        material.SetFloat(PROP_EMISSION_FRESNEL, fresnel);
                    }
                }
            }
        }
    }
}