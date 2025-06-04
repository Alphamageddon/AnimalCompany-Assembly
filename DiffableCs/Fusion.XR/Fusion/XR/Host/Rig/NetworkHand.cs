namespace Fusion.XR.Host.Rig;

[DefaultExecutionOrder(110)]
[RequireComponent(typeof(NetworkTransform))]
public class NetworkHand : NetworkBehaviour
{
	public const int EXECUTION_ORDER = 110; //Field offset: 0x0
	[HideInInspector]
	public NetworkTransform networkTransform; //Field offset: 0x80
	[CompilerGenerated]
	private HandCommand <HandCommand>k__BackingField; //Field offset: 0x88
	public RigPart side; //Field offset: 0xA0
	private NetworkRig rig; //Field offset: 0xA8
	private IHandRepresentation handRepresentation; //Field offset: 0xB0
	private ChangeDetector changeDetector; //Field offset: 0xB8

	[Networked]
	public HandCommand HandCommand
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public bool IsLocalNetworkRig
	{
		 get { } //Length: 36
	}

	public HardwareHand LocalHardwareHand
	{
		 get { } //Length: 76
	}

	public NetworkHand() { }

	private void Awake() { }

	[CompilerGenerated]
	public HandCommand get_HandCommand() { }

	public bool get_IsLocalNetworkRig() { }

	public HardwareHand get_LocalHardwareHand() { }

	public virtual void Render() { }

	[CompilerGenerated]
	public void set_HandCommand(HandCommand value) { }

	public virtual void Spawned() { }

	private void UpdateHandRepresentationWithNetworkState() { }

	private void UpdateRepresentationWithLocalHardwareState() { }

}

