namespace AnimalCompany;

public class Ammo : MonoBehaviour
{
        private GrabbableItem _grabbable; //Field offset: 0x20
        private LayerMask _gunCheckLayerMask; //Field offset: 0x28

        public Ammo() { }

        [CompilerGenerated]
        private int <CheckAndReload>b__5_0(Collider a, Collider b)
        {
                return a.GetInstanceID().CompareTo(b.GetInstanceID());
        }

        private void Awake()
        {
                _grabbable = GetComponent<GrabbableItem>();
                if (_grabbable != null)
                        _grabbable.OnUse += HandleOnUse;

                _gunCheckLayerMask = LayerMask.GetMask("Default");
        }

        private bool CheckAndReload()
        {
                Collider[] hits = Physics.OverlapSphere(transform.position, 0.25f, _gunCheckLayerMask);
                foreach (var hit in hits)
                {
                        var shotgun = hit.GetComponentInParent<Shotgun>();
                        if (shotgun != null)
                        {
                                shotgun.RPC_Reload();
                                return true;
                        }
                }
                return false;
        }

        private void HandleOnUse()
        {
                CheckAndReload();
        }

        private void OnDestroy()
        {
                if (_grabbable != null)
                        _grabbable.OnUse -= HandleOnUse;
        }

}

