// Decompiled with Xera AI Decompiler
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;

namespace AnimalCompany
{
    [NetworkBehaviourWeaved(1)]
    public class FlareGun : NetworkBehaviour
    {
        [CompilerGenerated]
        private sealed class <Shoot>d__14 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private object <>2__current;
            public FlareGun <>4__this;

            object IEnumerator<object>.Current
            {
                [DebuggerHidden]
                get { return <>2__current; }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get { return <>2__current; }
            }

            [DebuggerHidden]
            public <Shoot>d__14(int <>1__state)
            {
                this.<>1__state = <>1__state;
            }

            bool IEnumerator.MoveNext()
            {
                switch (<>1__state)
                {
                    case 0:
                        <>1__state = -1;
                        <>4__this._sfxShoot.PlaySFXAsRPC(transform.position, 1f);
                        
                        GameObject projectile = Instantiate(
                            <>4__this._projectilePrefab,
                            <>4__this._barrelTip.position,
                            <>4__this._barrelTip.rotation
                        );
                        
                        if (projectile.TryGetComponent<Rigidbody>(out var rb))
                        {
                            rb.AddForce(
                                <>4__this._barrelTip.forward * <>4__this._shootForce,
                                ForceMode.Impulse
                            );
                        }
                        
                        return false;
                    default:
                        return false;
                }
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
            }
        }

        [SerializeField]
        private GrabbableItem _grabbable;
        [SerializeField]
        private Transform _barrelTip;
        [SerializeField]
        private RandomSFX _sfxShoot;
        [SerializeField]
        private RandomSFX _sfxShootEmpty;
        [SerializeField]
        private float _shootForce = 12f;
        [SerializeField]
        private GameObject _projectilePrefab;
        [SerializeField]
        [WeaverGenerated]
        private bool _hasAmmo = true;

        [Networked]
        [NetworkedWeaved(0, 1)]
        public bool hasAmmo
        {
            get
            {
                if (Runner != null && Runner.HasStateAuthority)
                {
                    return _hasAmmo;
                }
                return NetworkedProperties.Get<bool>();
            }
            set
            {
                if (Runner != null && Runner.HasStateAuthority)
                {
                    _hasAmmo = value;
                }
                else
                {
                    NetworkedProperties.Set(value);
                }
            }
        }

        public FlareGun()
        {
            _shootForce = 12f;
            _hasAmmo = true;
        }

        private void Awake()
        {
            if (_grabbable != null)
            {
                _grabbable.OnUse += HandleUse;
                _grabbable.OnRespawned += HandleRespawned;
            }
        }

        private void OnDestroy()
        {
            if (_grabbable != null)
            {
                _grabbable.OnUse -= HandleUse;
                _grabbable.OnRespawned -= HandleRespawned;
            }
        }

        private void HandleUse()
        {
            if (hasAmmo)
            {
                StartCoroutine(Shoot());
                hasAmmo = false;
            }
            else
            {
                _sfxShootEmpty.PlaySFXAsRPC(transform.position, 1f);
            }
        }

        private void HandleRespawned()
        {
            hasAmmo = true;
        }

        [IteratorStateMachine(typeof(<Shoot>d__14))]
        private IEnumerator Shoot()
        {
            return new <Shoot>d__14(0)
            {
                <>4__this = this
            };
        }

        [WeaverGenerated]
        public virtual void CopyBackingFieldsToState(bool param_0)
        {
            hasAmmo = _hasAmmo;
        }

        [WeaverGenerated]
        public virtual void CopyStateToBackingFields()
        {
            _hasAmmo = hasAmmo;
        }
    }
}