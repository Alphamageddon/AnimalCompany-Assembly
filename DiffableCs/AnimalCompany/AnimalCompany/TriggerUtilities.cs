namespace AnimalCompany;

public class TriggerUtilities
{

	public TriggerUtilities() { }

	public static bool TryGetDamageableFromCollider(Collider col, out IDamageable damageable) { }

	public static bool TryGetItemFromCollider(Collider col, out GrabbableItem grabbableItem) { }

	public static bool TryGetNetPlayerFromCollider(Collider col, out NetPlayer netPlayer) { }

	public static bool TryGetStunnableFromCollider(Collider col, out IStunnable stunnable) { }

}

