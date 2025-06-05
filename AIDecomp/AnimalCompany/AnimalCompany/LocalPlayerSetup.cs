// Decompiled with Xera AI Decompiler
using UnityEngine;
using Fusion;

namespace AnimalCompany
{
    public class LocalPlayerSetup : MonoBehaviour
    {
        public bool enableQWOPEditorControls = true;
        public GameObject playerRig;
        private HardwareRig _hardwareRig;

        public LocalPlayerSetup()
        {
        }

        private void Start()
        {
            if (Application.isEditor && enableQWOPEditorControls && playerRig != null)
            {
                var qwopController = playerRig.GetComponent<QWOPController>();
                if (qwopController != null)
                {
                    qwopController.enabled = true;
                }

                var qwopInput = playerRig.GetComponent<QWOPInput>();
                if (qwopInput != null)
                {
                    qwopInput.enabled = true;
                }

                _hardwareRig = playerRig.GetComponent<HardwareRig>();
            }

            var networkRunner = FindObjectOfType<NetworkRunner>();
            if (networkRunner != null)
            {
                networkRunner.AddCallbacks(this);
            }
        }

        private void OnDestroy()
        {
            var networkRunner = FindObjectOfType<NetworkRunner>();
            if (networkRunner != null)
            {
                networkRunner.RemoveCallbacks(this);
            }
        }

        private void OnSetupRunner(NetworkRunner runner)
        {
            if (_hardwareRig != null)
            {
                _hardwareRig.StartWithRunner(runner);
            }
        }
    }
}