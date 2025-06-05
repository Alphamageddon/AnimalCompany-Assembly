// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class AnglerView : MobView
    {
        private static readonly int PROP_EMISSION_COLOR;
        
        [ColorUsage(false, true)]
        [SerializeField]
        private Color GLOW_ON_COLOR = new Color(1f, 0.8f, 0.4f, 1f);
        
        [ColorUsage(false, true)]
        [SerializeField]
        private Color GLOW_OFF_COLOR = new Color(0.1f, 0.1f, 0.1f, 1f);
        
        [Header("Render")]
        [SerializeField]
        private Light _escaLight;
        
        [SerializeField]
        private Renderer _renderer;
        
        [SerializeField]
        private DynamicBoneControl _dynamicBoneControl;
        
        [Header("Sound")]
        [SerializeField]
        private AudioSource _audioSourceFoundLight;
        
        [SerializeField]
        private AudioSource _audioSourceAnticipation;
        
        [SerializeField]
        private AudioSource _audioSourceRunning;
        
        [Header("Animation")]
        [SerializeField]
        private Transform _boneRoot;
        
        [SerializeField]
        private float _rootAnimSpeed = 1.5f;
        
        [SerializeField]
        private Vector2 _rootAnimRange = new Vector2(-0.5f, 0.5f);
        
        [SerializeField]
        private float _rootAnimYOffset = 0.8f;
        
        private Vector3 _boneRootInitialPositionLS;
        
        [SerializeField]
        [Space(5)]
        private Vector2 _rootAnimRotRange = new Vector2(-12f, 12f);
        
        [SerializeField]
        private Vector2 _rootAnimRotSpeedOffset = new Vector2(0.5f, 1.5f);
        
        [SerializeField]
        private float _rootAnimRotOffset = 0f;
        
        private Vector3 _boneRootInitialRotation;

        static AnglerView()
        {
            PROP_EMISSION_COLOR = Shader.PropertyToID("_EmissionColor");
        }

        public AnglerView()
        {
        }

        protected virtual void Awake()
        {
            base.Awake();
            
            if (_boneRoot != null)
            {
                _boneRootInitialPositionLS = _boneRoot.localPosition;
                _boneRootInitialRotation = _boneRoot.localRotation.eulerAngles;
            }
        }

        private void LateUpdate()
        {
            if (_boneRoot != null)
            {
                float time = Time.time;
                float animSpeed = _rootAnimSpeed;
                
                // Position animation
                float xOffset = Mathf.Sin(time * animSpeed) * _rootAnimRange.x;
                float yOffset = Mathf.Sin(time * animSpeed + _rootAnimYOffset) * _rootAnimRange.y;
                Vector3 newPosition = _boneRootInitialPositionLS + new Vector3(xOffset, yOffset, 0f);
                _boneRoot.localPosition = newPosition;
                
                // Rotation animation
                float rotSpeed = animSpeed + _rootAnimRotSpeedOffset.x;
                float rotOffset = Mathf.Sin(time * rotSpeed + _rootAnimRotOffset) * _rootAnimRotRange.x;
                Vector3 newRotation = _boneRootInitialRotation + new Vector3(0f, 0f, rotOffset);
                _boneRoot.localRotation = Quaternion.Euler(newRotation);
            }
        }

        public void PlayFoundLightSound()
        {
            if (_audioSourceFoundLight != null)
            {
                _audioSourceFoundLight.Play();
            }
        }

        public void PlayRunningSound(bool play, float volume = 1f)
        {
            if (_audioSourceRunning != null)
            {
                if (play)
                {
                    if (!_audioSourceRunning.isPlaying)
                    {
                        _audioSourceRunning.Play();
                    }
                }
                else
                {
                    if (_audioSourceRunning.isPlaying)
                    {
                        _audioSourceRunning.Stop();
                    }
                }
                
                _audioSourceRunning.volume = volume;
            }
        }

        public void SetAnimSpeed(bool isRunning)
        {
            if (_dynamicBoneControl != null)
            {
                _dynamicBoneControl.animSpeed = isRunning ? 3.5f : 1.5f;
            }
        }

        public virtual void SetAnticipation()
        {
            base.SetAnticipation();
            
            if (_audioSourceAnticipation != null)
            {
                _audioSourceAnticipation.Play();
            }
        }

        public void SetGlow(bool glow, bool forceZero = false)
        {
            if (_renderer != null)
            {
                Material material = _renderer.material;
                Color targetColor = glow ? GLOW_ON_COLOR : GLOW_OFF_COLOR;
                material.SetColor(PROP_EMISSION_COLOR, targetColor);
            }
            
            if (_escaLight != null)
            {
                _escaLight.enabled = glow;
                
                if (!glow && forceZero)
                {
                    _escaLight.intensity = 0f;
                }
            }
        }

        protected virtual void Update()
        {
            base.Update();
            
            if (_renderer != null && _dynamicBoneControl != null)
            {
                _dynamicBoneControl.enabled = _renderer.enabled;
            }
        }
    }
}