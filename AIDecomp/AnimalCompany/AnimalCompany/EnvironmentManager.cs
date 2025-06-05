// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.Netcode;
using System.Collections;

namespace AnimalCompany
{
    [NetworkBehaviourWeaved(0)]
    public class EnvironmentManager : NetworkBehaviour
    {
        private static EnvironmentManager _instance;
        private static Dictionary<int, List<NavPoint>> _navPoints;
        private static NavPoint[] _allNavPoints;
        
        [SerializeField]
        private NavMeshSurface _navMeshSurface;
        
        [SerializeField]
        private bool _buildNavMeshOnStart = true;
        
        private WaitForSeconds _waitForThirtySeconds;

        public static EnvironmentManager instance
        {
            get
            {
                return _instance;
            }
        }

        static EnvironmentManager()
        {
            _navPoints = new Dictionary<int, List<NavPoint>>();
        }

        public EnvironmentManager()
        {
            _buildNavMeshOnStart = true;
            _waitForThirtySeconds = new WaitForSeconds(30f);
        }

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

        private void OnDestroy()
        {
            if (_instance == this)
            {
                _instance = null;
            }
        }

        public override void Spawned()
        {
            base.Spawned();
            
            if (_navMeshSurface != null && _buildNavMeshOnStart)
            {
                _navMeshSurface.BuildNavMesh();
            }
        }

        [WeaverGenerated]
        public virtual void CopyBackingFieldsToState(bool param_0)
        {
        }

        [WeaverGenerated]
        public virtual void CopyStateToBackingFields()
        {
        }

        public static EnvironmentManager get_instance()
        {
            return instance;
        }
    }
}