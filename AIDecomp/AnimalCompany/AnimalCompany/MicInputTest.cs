// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class MicInputTest : MonoBehaviour
    {
        public static float MicLoudness;
        public PlayerView playerView;
        private string _device;
        private AudioClip _clipRecord;
        private int _sampleWindow = 128;
        public float multi = 1.0f;
        private bool _isInitialized;

        public MicInputTest()
        {
            _sampleWindow = 128;
        }

        private void InitMic()
        {
            if (_device == null)
            {
                if (Microphone.devices.Length > 0)
                {
                    _device = Microphone.devices[0];
                    _clipRecord = Microphone.Start(_device, true, 999, 44100);
                }
            }
        }

        private void StopMicrophone()
        {
            Microphone.End(_device);
        }

        private float LevelMax()
        {
            float levelMax = 0f;
            float[] waveData = new float[_sampleWindow];
            int micPosition = Microphone.GetPosition(_device) - (_sampleWindow + 1);
            
            if (micPosition < 0) return 0f;
            
            if (_clipRecord != null)
            {
                _clipRecord.GetData(waveData, micPosition);
                
                for (int i = 0; i < _sampleWindow; i++)
                {
                    float wavePeak = waveData[i] * waveData[i];
                    if (levelMax < wavePeak)
                    {
                        levelMax = wavePeak;
                    }
                }
            }
            
            return levelMax;
        }

        private void Update()
        {
            MicLoudness = LevelMax();
            
            if (playerView != null)
            {
                playerView.UpdateVoice(MicLoudness * multi);
            }
        }

        private void OnEnable()
        {
            InitMic();
            _isInitialized = true;
        }

        private void OnDisable()
        {
            StopMicrophone();
        }

        private void OnDestroy()
        {
            StopMicrophone();
        }

        private void OnApplicationFocus(bool focus)
        {
            if (focus)
            {
                if (!_isInitialized)
                {
                    InitMic();
                    _isInitialized = true;
                }
            }
            else
            {
                StopMicrophone();
                _isInitialized = false;
            }
        }
    }
}