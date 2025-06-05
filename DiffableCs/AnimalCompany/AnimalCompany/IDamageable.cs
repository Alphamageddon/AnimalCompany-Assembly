namespace AnimalCompany;

public interface IDamageable
{

	public void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName) { }

}

