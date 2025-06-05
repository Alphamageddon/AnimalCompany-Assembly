// Decompiled with Xera AI Decompiler
using Fusion;
using UnityEngine;
using System.Collections.Generic;

namespace AnimalCompany
{
    public class NetworkVFX : SimulationBehaviour
    {
        private static NetworkVFX _instance;
        
        public NetworkRunner runner;
        public SerializableDictionary<NetworkVFXType, ParticleSystem> particles;

        private void Awake()
        {
            _instance = this;
            
            if (runner != null)
            {
                runner.AddCallbacks(this);
            }
        }

        private void HandleNewRunner(NetworkRunner runner)
        {
            this.runner = runner;
        }

        public static void PlayVFX(NetworkVFXType type, Vector3 position, Quaternion rotation)
        {
            if (_instance == null) return;
            
            var networkRunner = _instance.runner;
            if (networkRunner != null && networkRunner.HasStateAuthority)
            {
                RPC_PlayVFX(networkRunner, type, position, rotation);
            }
        }

        [Rpc(RpcSources.All, RpcTargets.All)]
        private static void RPC_PlayVFX(NetworkRunner runner, NetworkVFXType type, Vector3 position, Quaternion rotation)
        {
            if (_instance == null) return;
            
            if (_instance.particles != null && _instance.particles.TryGetValue(type, out ParticleSystem particleSystem))
            {
                if (particleSystem != null)
                {
                    var transform = particleSystem.transform;
                    if (transform != null)
                    {
                        transform.position = position;
                        transform.rotation = rotation;
                        particleSystem.Play();
                    }
                }
            }
        }

        [NetworkRpcStaticWeavedInvoker("System.Void AnimalCompany.NetworkVFX::RPC_PlayVFX(Fusion.NetworkRunner,AnimalCompany.NetworkVFXType,UnityEngine.Vector3,UnityEngine.Quaternion)")]
        [Preserve]
        [WeaverGenerated]
        protected static void RPC_PlayVFX_Invoker(NetworkRunner runner, SimulationMessage* message)
        {
            Assert.Check(true);
            
            if (_instance == null) return;
            
            var type = (NetworkVFXType)message->ReadInt32();
            var position = message->ReadVector3();
            var rotation = message->ReadQuaternion();
            
            RPC_PlayVFX(runner, type, position, rotation);
        }

        public NetworkVFX()
        {
            particles = new SerializableDictionary<NetworkVFXType, ParticleSystem>();
        }
    }
}