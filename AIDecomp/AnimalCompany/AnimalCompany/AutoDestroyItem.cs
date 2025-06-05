using UnityEngine;
using Fusion;

namespace AnimalCompany
{
    [NetworkBehaviourWeaved(1)]
    public class AutoDestroyItem : NetworkBehaviour
    {
        [SerializeField]
        private float _timeToDestroy = 10f;
        
        [DefaultForProperty("life", 0, 1)]
        [DrawIf("IsEditorWritable", true, CompareOperator.Equal, DrawIfMode.ReadOnly)]
        [WeaverGenerated]
        private TickTimer _life;

        [Networked]
        [NetworkedWeaved(0, 1)]
        private TickTimer life
        {
            get => _life;
            set => _life = value;
        }

        public AutoDestroyItem()
        {
            _timeToDestroy = 10f;
        }

        [WeaverGenerated]
        public virtual void CopyBackingFieldsToState(bool param_0)
        {
            life = _life;
        }

        [WeaverGenerated]
        public virtual void CopyStateToBackingFields()
        {
            _life = life;
        }

        public override void Spawned()
        {
            base.Spawned();
            
            if (Object != null && !Object.IsProxy && Object.HasStateAuthority)
            {
                life = TickTimer.CreateFromSeconds(Runner, _timeToDestroy);
            }
        }

        public override void FixedUpdateNetwork()
        {
            base.FixedUpdateNetwork();
            
            if (Object != null && !Object.IsProxy && Object.HasStateAuthority)
            {
                if (life.Expired(Runner))
                {
                    if (Runner != null)
                    {
                        Runner.Despawn(Object);
                    }
                }
            }
        }
    }
}