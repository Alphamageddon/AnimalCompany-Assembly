// Decompiled with Xera AI Decompiler
using Fusion;

namespace AnimalCompany
{
    [NetworkBehaviourWeaved(0)]
    public class MasterClientSwitchDetector : NetworkBehaviour, IStateAuthorityChanged
    {
        public MasterClientSwitchDetector()
        {
        }

        [WeaverGenerated]
        public virtual void CopyBackingFieldsToState(bool param_0)
        {
        }

        [WeaverGenerated]
        public virtual void CopyStateToBackingFields()
        {
        }

        public override void StateAuthorityChanged()
        {
            if (Object != null && Object.IsValid)
            {
                var runner = NetworkRunner.GetRunnerForGameObject(gameObject);
                if (runner != null)
                {
                    var stateAuthority = Object.StateAuthority;
                    // Handle state authority change logic here
                }
            }
        }
    }
}