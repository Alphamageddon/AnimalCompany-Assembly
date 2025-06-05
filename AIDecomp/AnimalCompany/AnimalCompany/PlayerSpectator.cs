using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR;

namespace AnimalCompany
{
    public class PlayerSpectator : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class <SetSpectatorCamera>d__10 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private object <>2__current;
            public bool isSpectator;
            public PlayerSpectator <>4__this;
            public Vector3 cameraForward;
            public Vector3 cameraPosition;

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
            public <SetSpectatorCamera>d__10(int <>1__state)
            {
                this.<>1__state = <>1__state;
            }

            bool IEnumerator.MoveNext()
            {
                int state = this.<>1__state;
                PlayerSpectator playerSpectator = this.<>4__this;
                
                switch (state)
                {
                    case 0:
                        this.<>1__state = -1;
                        
                        if (isSpectator)
                        {
                            // Enable spectator camera
                            if (playerSpectator._cameraSpectator != null)
                            {
                                playerSpectator._cameraSpectator.enabled = true;
                                playerSpectator._cameraSpectator.transform.position = cameraPosition;
                                playerSpectator._cameraSpectator.transform.forward = cameraForward;
                            }
                            
                            // Disable head camera
                            if (playerSpectator._cameraHead != null)
                            {
                                playerSpectator._cameraHead.enabled = false;
                            }
                            
                            // Disable tracked pose drivers
                            if (playerSpectator._trackedPoseDriverHead != null)
                            {
                                playerSpectator._trackedPoseDriverHead.enabled = false;
                            }
                            
                            if (playerSpectator._trackedPoseDriverSpectator != null)
                            {
                                playerSpectator._trackedPoseDriverSpectator.enabled = true;
                            }
                        }
                        else
                        {
                            // Enable head camera
                            if (playerSpectator._cameraHead != null)
                            {
                                playerSpectator._cameraHead.enabled = true;
                            }
                            
                            // Disable spectator camera
                            if (playerSpectator._cameraSpectator != null)
                            {
                                playerSpectator._cameraSpectator.enabled = false;
                            }
                            
                            // Enable tracked pose drivers
                            if (playerSpectator._trackedPoseDriverHead != null)
                            {
                                playerSpectator._trackedPoseDriverHead.enabled = true;
                            }
                            
                            if (playerSpectator._trackedPoseDriverSpectator != null)
                            {
                                playerSpectator._trackedPoseDriverSpectator.enabled = false;
                            }
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

        [Header("References")]
        [SerializeField]
        private PlayerView _playerView;
        [SerializeField]
        private Player _gorillaPlayer;
        [SerializeField]
        private XRController _xrControllerLeft;
        [SerializeField]
        private XRController _xrControllerRight;
        [SerializeField]
        private Camera _cameraHead;
        [SerializeField]
        private Camera _cameraSpectator;
        [SerializeField]
        private Transform _spectatorRoot;
        [SerializeField]
        private TrackedPoseDriver _trackedPoseDriverHead;
        [SerializeField]
        private TrackedPoseDriver _trackedPoseDriverSpectator;

        public PlayerSpectator()
        {
        }

        private void Awake()
        {
            if (_cameraSpectator != null)
            {
                _cameraSpectator.enabled = false;
            }
            
            if (_trackedPoseDriverSpectator != null)
            {
                _trackedPoseDriverSpectator.enabled = false;
            }
        }

        [IteratorStateMachine(typeof(<SetSpectatorCamera>d__10))]
        public IEnumerator SetSpectatorCamera(bool isSpectator, Vector3 cameraPosition = default(Vector3), Vector3 cameraForward = default(Vector3))
        {
            <SetSpectatorCamera>d__10 d = new <SetSpectatorCamera>d__10(0);
            d.<>4__this = this;
            d.isSpectator = isSpectator;
            d.cameraPosition = cameraPosition;
            d.cameraForward = cameraForward;
            return d;
        }
    }
}