namespace AnimalCompany;

[CreateAssetMenu(fileName = "PlayerControlAsset", menuName = "PlayerControlAsset", order = 0)]
public class PlayerControlAsset : ScriptableObject
{
	public int velocityHistorySize; //Field offset: 0x18
	public float maxArmLength; //Field offset: 0x1C
	public float unStickDistance; //Field offset: 0x20
	public float velocityLimit; //Field offset: 0x24
	public float maxJumpSpeed; //Field offset: 0x28
	public float jumpMultiplier; //Field offset: 0x2C
	public float minimumRaycastDistance; //Field offset: 0x30
	public float defaultSlideFactor; //Field offset: 0x34
	public float defaultPrecision; //Field offset: 0x38
	public Vector3 leftHandOffset; //Field offset: 0x3C
	public Vector3 rightHandOffset; //Field offset: 0x48
	public LayerMask locomotionEnabledLayers; //Field offset: 0x54

	public PlayerControlAsset() { }

	public void Setup(Player player) { }

}

