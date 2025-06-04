namespace Fusion;

[DisallowMultipleComponent]
[NetworkBehaviourWeaved(14)]
public class NetworkTRSP : NetworkBehaviour
{
	[CompilerGenerated]
	private bool <IsMainTRSP>k__BackingField; //Field offset: 0x80

	public NetworkTRSPData Data
	{
		 get { } //Length: 144
	}

	public internal bool IsMainTRSP
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	protected NetworkTRSPData State
	{
		 get { } //Length: 76
	}

	public NetworkTRSP() { }

	public NetworkTRSPData get_Data() { }

	[CompilerGenerated]
	public bool get_IsMainTRSP() { }

	protected NetworkTRSPData get_State() { }

	protected static void Render(NetworkTRSP behaviour, Transform transform, bool syncScale, bool syncParent, bool local, ref Tick initial) { }

	protected static void ResolveAOIOverride(NetworkTRSP behaviour, Transform parent) { }

	[CompilerGenerated]
	internal void set_IsMainTRSP(bool value) { }

	public override void SetAreaOfInterestOverride(NetworkObject obj) { }

	protected static void SetParentTransform(NetworkTRSP behaviour, Transform transform, NetworkBehaviourId parentId) { }

	protected static void Teleport(NetworkTRSP behaviour, Transform transform, Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null) { }

}

