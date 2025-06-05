// Decompiled with Xera AI Decompiler
using UnityEngine;
using Fusion;

namespace AnimalCompany
{
    [NetworkBehaviourWeaved(1)]
    public class Boombox : NetworkBehaviour
    {
        [SerializeField]
        private GrabbableItem _grabbable;
        
        [SerializeField]
        private RandomSFX _SFXswitch;
        
        [SerializeField]
        private AudioSource _audioSource;
        
        [DefaultForProperty("isOn", 0, 1)]
        [DrawIf("IsEditorWritable", true, CompareOperator.Equal, DrawIfMode.ReadOnly)]
        [SerializeField]
        [WeaverGenerated]
        private bool _isOn;

        [Networked]
        [NetworkedWeaved(0, 1)]
        [OnChangedRender("HandleIsOnChanged")]
        public bool isOn
        {
            get
            {
                if (_grabbable != null)
                {
                    return _grabbable.isOn;
                }
                throw new System.InvalidOperationException("Grabbable is null");
            }
            set
            {
                if (_grabbable != null)
                {
                    _grabbable.isOn = value;
                }
                else
                {
                    throw new System.InvalidOperationException("Grabbable is null");
                }
            }
        }

        public Boombox()
        {
        }

        private void Awake()
        {
            if (_grabbable != null)
            {
                _grabbable.OnToggleUse += HandleToggleUse;
            }
        }

        private void OnDestroy()
        {
            if (_grabbable != null)
            {
                _grabbable.OnToggleUse -= HandleToggleUse;
            }
        }

        public override void Spawned()
        {
            base.Spawned();
        }

        [Rpc(RpcSources.All, RpcTargets.StateAuthority)]
        public void RPC_ToggleOnOff()
        {
            if (Object.HasStateAuthority)
            {
                isOn = !isOn;
            }
        }

        private void HandleToggleUse()
        {
            RPC_ToggleOnOff();
        }

        private void HandleIsOnChanged()
        {
            if (_SFXswitch != null)
            {
                Vector3 position = transform.position;
                SFXManager.PlaySFX(_SFXswitch, position, 1f);
            }

            if (_audioSource != null)
            {
                if (isOn)
                {
                    _audioSource.Play();
                }
                else
                {
                    _audioSource.Pause();
                }
            }
        }

        [WeaverGenerated]
        public virtual void CopyBackingFieldsToState(bool param_0)
        {
            isOn = _isOn;
        }

        [WeaverGenerated]
        public virtual void CopyStateToBackingFields()
        {
            _isOn = isOn;
        }

        [NetworkRpcWeavedInvoker(1, 7, 1)]
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Preserve)]
        [WeaverGenerated]
        protected static void RPC_ToggleOnOff_Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
        {
            if (behaviour is Boombox boombox)
            {
                boombox.RPC_ToggleOnOff();
            }
        }
    }
}