namespace AnimalCompany;

public class TeleportTarget : MonoBehaviour
{
	public static Dictionary<TeleTarget, Transform> teleportTargets; //Field offset: 0x0
	public TeleTarget target; //Field offset: 0x20

	private static TeleportTarget() { }

	public TeleportTarget() { }

	private void Awake() { }

	private void OnDestroy() { }

	public static bool TryGetTeleportTarget(TeleTarget target, out Transform transform) { }

}

