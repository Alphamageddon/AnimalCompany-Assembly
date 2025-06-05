// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class RedGreenView : MobView
    {
        private static readonly int PROP_IS_GREEN;
        private static readonly int PROP_IS_EVIL;
        
        [ColorUsage(false, true)]
        [SerializeField]
        private Color _greenColor;
        
        [ColorUsage(false, true)]
        [SerializeField]
        private Color _redColor;
        
        [SerializeField]
        private Light _light;
        
        [SerializeField]
        private MeshRenderer _lightMeshRenderer;
        
        [Header("Audio_Monster")]
        [SerializeField]
        private AudioSource _audioSourceAnticipation;
        
        [SerializeField]
        private AudioSource _audioSourceBackToStand;
        
        [SerializeField]
        private AudioSource _audioSourceRunning;
        
        [SerializeField]
        private AudioSource _audioSourceWalking;
        
        [SerializeField]
        private AudioSource _audioSourceSaw;
        
        [Header("Audio_Lights")]
        [SerializeField]
        private AudioSource _audioSourceLightGreen;
        
        [SerializeField]
        private AudioSource _audioSourceLightGreenLoop;
        
        [SerializeField]
        private AudioSource _audioSourceLightRed;
        
        [Header("Saws")]
        [SerializeField]
        private Transform[] _sawTransforms;
        
        private bool _isSawRotating;
        private float[] _sawRotationSpeeds;

        static RedGreenView()
        {
            PROP_IS_GREEN = Shader.PropertyToID("_IsGreen");
            PROP_IS_EVIL = Shader.PropertyToID("_IsEvil");
        }

        public RedGreenView()
        {
            _sawRotationSpeeds = new float[8];
            for (int i = 0; i < _sawRotationSpeeds.Length; i++)
            {
                _sawRotationSpeeds[i] = 1f;
            }
        }

        public void PlayAnticipationSound()
        {
            if (_audioSourceAnticipation != null)
            {
                if (_audioSourceAnticipation.isPlaying)
                {
                    _audioSourceAnticipation.Stop();
                }
                _audioSourceAnticipation.Play();
            }
        }

        public void PlayBackToStandSound()
        {
            if (_audioSourceBackToStand != null)
            {
                if (_audioSourceBackToStand.isPlaying)
                {
                    _audioSourceBackToStand.Stop();
                }
                _audioSourceBackToStand.Play();
            }
        }

        public void PlayRunningSound(bool play)
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
            }
        }

        private void PlaySawSound(bool play)
        {
            if (_audioSourceSaw != null)
            {
                if (play)
                {
                    if (!_audioSourceSaw.isPlaying)
                    {
                        _audioSourceSaw.Play();
                    }
                }
                else
                {
                    if (_audioSourceSaw.isPlaying)
                    {
                        _audioSourceSaw.Stop();
                    }
                }
            }
        }

        public void PlayWalkingSound(bool play)
        {
            if (_audioSourceWalking != null)
            {
                if (play)
                {
                    if (!_audioSourceWalking.isPlaying)
                    {
                        _audioSourceWalking.Play();
                    }
                }
                else
                {
                    if (_audioSourceWalking.isPlaying)
                    {
                        _audioSourceWalking.Stop();
                    }
                }
            }
        }

        public void SetLightColor(bool isGreen)
        {
            if (_light != null)
            {
                _light.color = isGreen ? _greenColor : _redColor;
            }

            if (_lightMeshRenderer != null)
            {
                Material material = _lightMeshRenderer.material;
                if (material != null)
                {
                    material.SetFloat(PROP_IS_GREEN, isGreen ? 1f : 0f);
                }
            }

            if (isGreen)
            {
                if (_audioSourceLightGreen != null)
                {
                    _audioSourceLightGreen.Play();
                }
                if (_audioSourceLightGreenLoop != null)
                {
                    _audioSourceLightGreenLoop.Play();
                }
            }
            else
            {
                if (_audioSourceLightRed != null)
                {
                    _audioSourceLightRed.Play();
                }
                if (_audioSourceLightGreenLoop != null)
                {
                    _audioSourceLightGreenLoop.Stop();
                }
            }
        }

        public void SetLightEvil(bool isEvil)
        {
            if (_lightMeshRenderer != null)
            {
                Material material = _lightMeshRenderer.material;
                if (material != null)
                {
                    material.SetFloat(PROP_IS_EVIL, isEvil ? 1f : 0f);
                }
            }
        }

        public void SetSawRotation(bool rotate)
        {
            _isSawRotating = rotate;
            PlaySawSound(rotate);
        }

        protected virtual void Update()
        {
            if (_isSawRotating && _sawTransforms != null)
            {
                for (int i = 0; i < _sawTransforms.Length; i++)
                {
                    if (_sawTransforms[i] != null)
                    {
                        float rotationSpeed = _sawRotationSpeeds[i] * Time.deltaTime;
                        _sawTransforms[i].Rotate(Vector3.forward, rotationSpeed);
                    }
                }
            }
        }
    }
}