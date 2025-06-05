// Decompiled with Xera AI Decompiler
using Fusion;
using UnityEngine;

[NetworkBehaviourWeaved(1)]
public class FlareGunProjectile : NetworkBehaviour
{
    public float lifetime;
    public int damage;
    public float explosionRadius;
    public RandomSFX explosionSound;
    private NetworkVFXType deathVFX;
    private float explosionForce;
    
    [DefaultForProperty("aliveTimer", 0, 1)]
    [DrawIf("IsEditorWritable", true, CompareOperator.Equal, DrawIfMode.ReadOnly)]
    [WeaverGenerated]
    private TickTimer _aliveTimer;

    [Networked]
    [NetworkedWeaved(0, 1)]
    private TickTimer aliveTimer
    {
        get
        {
            if (Object == null)
                throw new System.InvalidOperationException();
            return Object.GetNetworkedProperty<TickTimer>();
        }
        set
        {
            if (Object == null)
                throw new System.InvalidOperationException();
            Object.SetNetworkedProperty(value);
        }
    }

    public FlareGunProjectile()
    {
        damage = 50;
        explosionForce = 25.0f;
    }

    [WeaverGenerated]
    public virtual void CopyBackingFieldsToState(bool param_0)
    {
        aliveTimer = _aliveTimer;
    }

    [WeaverGenerated]
    public virtual void CopyStateToBackingFields()
    {
        _aliveTimer = aliveTimer;
    }

    public virtual void FixedUpdateNetwork()
    {
        if (Object.HasStateAuthority && aliveTimer.Expired(Runner))
        {
            NetworkVFX.PlayVFX(deathVFX, transform.position, transform.rotation);
            
            var colliders = Physics.OverlapSphere(transform.position, explosionRadius);
            
            foreach (var collider in colliders)
            {
                var health = collider.GetComponent<Health>();
                if (health != null)
                {
                    health.TakeDamage(damage, transform.position);
                }
                
                var rigidbody = collider.attachedRigidbody;
                if (rigidbody != null)
                {
                    rigidbody.AddExplosionForce(explosionForce, transform.position, explosionRadius, 1.0f);
                }
            }
            
            if (explosionSound != null)
            {
                explosionSound.Play(transform.position, 1.0f, true);
            }
            
            Runner.Despawn(Object);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }

    public virtual void Spawned()
    {
        base.Spawned();
        aliveTimer = TickTimer.CreateFromSeconds(Runner, lifetime);
    }
}