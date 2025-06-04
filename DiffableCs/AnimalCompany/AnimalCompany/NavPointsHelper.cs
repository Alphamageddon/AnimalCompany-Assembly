namespace AnimalCompany;

public class NavPointsHelper : MonoBehaviour
{
	public int zoneId; //Field offset: 0x20
	public Vector3 direction; //Field offset: 0x24
	public Vector3 directionPoint; //Field offset: 0x30

	public NavPointsHelper() { }

	[ContextMenu("ApplyLayer")]
	public void ApplyLayer() { }

	[ContextMenu("ApplyRotaionTowardsPoint")]
	public void ApplyRotaionTowardsPoint() { }

	[ContextMenu("ApplyRotation")]
	public void ApplyRotation() { }

	private NavPoint[] GetNavPoints() { }

	[ContextMenu("StickToGround")]
	public void StickToGround() { }

}

