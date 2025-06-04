namespace AnimalCompany;

[CreateAssetMenu(fileName = "MobData", menuName = "AnimalCompany/MobData", order = 1)]
public class MobData : ScriptableObject
{
	public string monsterName; //Field offset: 0x18
	public int health; //Field offset: 0x20
	public int attackDamage; //Field offset: 0x24
	[Header("AI-Roaming")]
	[Tooltip("Seconds between attacks")]
	public float attackSpeed; //Field offset: 0x28
	[Tooltip("Meter per second")]
	public Single[] walkSpeed; //Field offset: 0x30
	[Tooltip("Meter per second")]
	public Single[] runSpeed; //Field offset: 0x38
	[Tooltip("Degrees per second")]
	public float steeringSpeed; //Field offset: 0x40
	[Tooltip("Seconds")]
	public float timeHoldAtNavPoint; //Field offset: 0x44
	[Header("Physics")]
	public float bodySize; //Field offset: 0x48
	public float attackRange; //Field offset: 0x4C
	public float attackForce; //Field offset: 0x50
	[Header("AI-Chasing")]
	public Single[] searchPrecision; //Field offset: 0x58
	public Single[] searchWidth; //Field offset: 0x60
	public float timeChasing; //Field offset: 0x68
	public float timeSearching; //Field offset: 0x6C
	[Header("Sense")]
	public float fov; //Field offset: 0x70
	public Single[] viewDistance; //Field offset: 0x78
	public float hearingDistance; //Field offset: 0x80
	public float hearingSensitivity; //Field offset: 0x84
	public float angerMeterToAttack; //Field offset: 0x88
	[Header("Respawn")]
	public bool isRespawnInRandomNavPoint; //Field offset: 0x8C
	public float timeRevive; //Field offset: 0x90
	[Header("Sound")]
	public RandomSFX emergeSFX; //Field offset: 0x98
	public RandomSFX encounterSFX; //Field offset: 0xA0
	public RandomSFX footstepSFX; //Field offset: 0xA8
	public RandomSFX attackSFX; //Field offset: 0xB0
	public RandomSFX killSFX; //Field offset: 0xB8
	public RandomSFX hitSFX; //Field offset: 0xC0
	public RandomSFX dieSFX; //Field offset: 0xC8

	public float attackRangeSqr
	{
		 get { } //Length: 12
	}

	public float bodySizeSqr
	{
		 get { } //Length: 12
	}

	public float hearingDistanceSqr
	{
		 get { } //Length: 12
	}

	public MobData() { }

	public float get_attackRangeSqr() { }

	public float get_bodySizeSqr() { }

	public float get_hearingDistanceSqr() { }

}

