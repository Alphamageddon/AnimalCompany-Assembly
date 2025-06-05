using UnityEngine;
using UnityEngine.Audio;

namespace AnimalCompany
{
    [CreateAssetMenu(fileName = "EnvironmentVolumeProfile", menuName = "EnvironmentVolumeProfile")]
    public class EnvironmentVolumeProfile : ScriptableObject
    {
        [Header("Environment")]
        public Color realtimeShadowColor;
        public Color ambientColor;
        public Color skyboxColor;
        
        [Header("Fog")]
        [Space]
        public Color fogColor;
        public float fogDensity;
        
        [Header("Directional Light")]
        [Space]
        public Color directionalLightColor;
        public float directionalLightIntensity;
        
        [Header("Spookiness")]
        [Space]
        [Range(0, 1)]
        public float spookiness;
        
        [Header("Audio")]
        [Space]
        [Tooltip("Only non-custom presets work right now.")]
        public AudioReverbPreset reverbPreset;
        
        [Header("Physics")]
        [Space]
        public bool useCustomGravity;
        public Vector3 customGravity;

        public EnvironmentVolumeProfile()
        {
        }
    }
}