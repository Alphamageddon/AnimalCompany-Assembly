namespace AnimalCompany;

public interface IDamageable
{
        // Called when an object takes damage. Implementations should apply the
        // damage amount and play any hit or kill effects at the supplied
        // position with the given force.
        void Hit(int damage, Vector3 position, RandomSFX hitSound,
                RandomSFX killSound, Vector3 force, string hitName,
                NetworkBehaviourId source);
}

