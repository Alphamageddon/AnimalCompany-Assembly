// Decompiled with Xera AI Decompiler
using UnityEngine;
using System.Runtime.CompilerServices;

namespace AnimalCompany
{
    [ExecuteAlways]
    public class EnvironmentVolumeManager : MonoBehaviour
    {
        private static readonly int PROP_SPOOKINESS_GLOBAL;
        private const float LERP_SPEED = 0.333f;
        
        public static EnvironmentVolumeManager instance;
        private static float _lerpSlider;
        
        [CompilerGenerated]
        private EnvironmentVolumeProfile <currentProfile>k__BackingField;
        
        public Light mainDirectionalLight;
        private float _currentSpookiness;

        public EnvironmentVolumeProfile currentProfile
        {
            [CompilerGenerated]
            get { return <currentProfile>k__BackingField; }
            [CompilerGenerated]
            private set { <currentProfile>k__BackingField = value; }
        }

        static EnvironmentVolumeManager()
        {
            PROP_SPOOKINESS_GLOBAL = Shader.PropertyToID("_SpookinessGlobal");
        }

        public EnvironmentVolumeManager()
        {
        }

        private void Awake()
        {
            instance = this;
            RenderSettings.skybox = new Material(RenderSettings.skybox);
        }

        [CompilerGenerated]
        public EnvironmentVolumeProfile get_currentProfile()
        {
            return <currentProfile>k__BackingField;
        }

        private void OnEnable()
        {
            if (instance != null && instance != this)
            {
                Destroy(this);
            }
        }

        [CompilerGenerated]
        private void set_currentProfile(EnvironmentVolumeProfile value)
        {
            <currentProfile>k__BackingField = value;
        }

        public static void SetEnvironmentProfile(EnvironmentVolumeProfile profile)
        {
            if (instance != null && instance.currentProfile != profile)
            {
                instance.currentProfile = profile;
            }
        }

        private void Update()
        {
            if (currentProfile == null)
                return;

            _lerpSlider = Mathf.Clamp01(_lerpSlider + Time.deltaTime * LERP_SPEED);

            // Lerp subtractive shadow color
            Color targetSubtractiveShadow = currentProfile.subtractiveShadowColor;
            Color currentSubtractiveShadow = RenderSettings.subtractiveShadowColor;
            RenderSettings.subtractiveShadowColor = Color.Lerp(currentSubtractiveShadow, targetSubtractiveShadow, _lerpSlider);

            // Lerp ambient light
            Color targetAmbient = currentProfile.ambientLight;
            Color currentAmbient = RenderSettings.ambientLight;
            RenderSettings.ambientLight = Color.Lerp(currentAmbient, targetAmbient, _lerpSlider);

            // Lerp fog color
            Color targetFogColor = currentProfile.fogColor;
            Color currentFogColor = RenderSettings.fogColor;
            RenderSettings.fogColor = Color.Lerp(currentFogColor, targetFogColor, _lerpSlider);

            // Lerp fog density
            float targetFogDensity = currentProfile.fogDensity;
            float currentFogDensity = RenderSettings.fogDensity;
            RenderSettings.fogDensity = Mathf.Lerp(currentFogDensity, targetFogDensity, _lerpSlider);

            // Lerp skybox tint
            if (RenderSettings.skybox != null)
            {
                Color targetSkyboxTint = currentProfile.skyboxTint;
                Color currentSkyboxTint = RenderSettings.skybox.GetColor("_Tint");
                RenderSettings.skybox.SetColor("_Tint", Color.Lerp(currentSkyboxTint, targetSkyboxTint, _lerpSlider));
            }

            // Lerp main directional light
            if (mainDirectionalLight != null)
            {
                Color targetLightColor = currentProfile.mainLightColor;
                Color currentLightColor = mainDirectionalLight.color;
                mainDirectionalLight.color = Color.Lerp(currentLightColor, targetLightColor, _lerpSlider);

                float targetLightIntensity = currentProfile.mainLightIntensity;
                float currentLightIntensity = mainDirectionalLight.intensity;
                mainDirectionalLight.intensity = Mathf.Lerp(currentLightIntensity, targetLightIntensity, _lerpSlider);
            }

            // Update spookiness
            float targetSpookiness = currentProfile.spookiness;
            _currentSpookiness = Mathf.Lerp(_currentSpookiness, targetSpookiness, _lerpSlider);
            Shader.SetGlobalFloat(PROP_SPOOKINESS_GLOBAL, _currentSpookiness);
        }
    }
}