// Decompiled with Xera AI Decompiler
using UnityEngine;
using Fusion;
using System;

namespace AnimalCompany
{
    [NetworkBehaviourWeaved(1)]
    public class Scanner : NetworkBehaviour
    {
        private const int RENDER_WIDTH = 240;
        private const int RENDER_HEIGHT = 320;
        
        [SerializeField]
        private GrabbableItem _grabbable;
        
        [SerializeField]
        private Camera _camera;
        
        [SerializeField]
        private Renderer _displayRenderer;
        
        [SerializeField]
        private Shader _replacementShader;
        
        [SerializeField]
        private Material _processMaterial;
        
        [DefaultForProperty("isOn", 0, 1)]
        [DrawIf("IsEditorWritable", true, CompareOperator.Equal, DrawIfMode.ReadOnly)]
        [SerializeField]
        [WeaverGenerated]
        private bool _isOn;
        
        private RenderTexture _texture;
        private RenderTexture _viewTexture;

        [Networked]
        [NetworkedWeaved(0, 1)]
        [OnChangedRender("HandleIsOnChanged")]
        public bool isOn
        {
            get
            {
                var networkData = GetNetworkData();
                if (networkData != null)
                {
                    return networkData.ReadBool();
                }
                throw new InvalidOperationException("Network data not available");
            }
            set
            {
                var networkData = GetNetworkData();
                if (networkData != null)
                {
                    networkData.WriteBool(value);
                    return;
                }
                throw new InvalidOperationException("Network data not available");
            }
        }

        public Scanner() { }

        private void Awake()
        {
            _texture = new RenderTexture(RENDER_WIDTH, RENDER_HEIGHT, 16);
            _viewTexture = new RenderTexture(RENDER_WIDTH, RENDER_HEIGHT, 0);
            
            if (_camera != null)
            {
                _camera.targetTexture = _texture;
                _camera.SetReplacementShader(_replacementShader, "");
            }
            
            if (_displayRenderer != null && _displayRenderer.material != null)
            {
                _displayRenderer.material.mainTexture = _viewTexture;
            }
            
            if (_grabbable != null)
            {
                _grabbable.onUse += HandleToggleUse;
            }
        }

        private void OnDestroy()
        {
            if (_grabbable != null)
            {
                _grabbable.onUse -= HandleToggleUse;
            }
        }

        public override void Spawned()
        {
            base.Spawned();
        }

        [Rpc(RpcSources.All, RpcTargets.StateAuthority)]
        public void RPC_ToggleOnOff()
        {
            if (HasStateAuthority)
            {
                isOn = !isOn;
            }
        }

        [NetworkRpcWeavedInvoker(1, 7, 1)]
        [Preserve]
        [WeaverGenerated]
        protected static void RPC_ToggleOnOff_Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
        {
            if (behaviour is Scanner scanner)
            {
                scanner.RPC_ToggleOnOff();
            }
        }

        private void HandleToggleUse()
        {
            RPC_ToggleOnOff();
        }

        private void Update()
        {
            if (Object != null && Object.IsValid && isOn)
            {
                Graphics.Blit(_texture, _viewTexture, _processMaterial);
            }
        }

        private void HandleIsOnChanged()
        {
            if (_camera != null)
            {
                _camera.enabled = isOn;
            }
            
            if (!isOn)
            {
                RenderTexture.active = _viewTexture;
                GL.Clear(true, true, Color.clear);
                RenderTexture.active = null;
            }
        }

        [WeaverGenerated]
        public override void CopyBackingFieldsToState(bool firstTime)
        {
            isOn = _isOn;
        }

        [WeaverGenerated]
        public override void CopyStateToBackingFields()
        {
            _isOn = isOn;
        }
    }
}