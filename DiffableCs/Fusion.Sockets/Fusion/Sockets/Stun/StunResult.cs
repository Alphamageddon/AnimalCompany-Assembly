namespace Fusion.Sockets.Stun;

internal class StunResult
{
	public static readonly StunResult Invalid; //Field offset: 0x0
	public NATType NatType; //Field offset: 0x10
	[CompilerGenerated]
	private NetAddress <PublicEndPoint>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private NetAddress <PrivateEndPoint>k__BackingField; //Field offset: 0x30

	public bool IsValid
	{
		 get { } //Length: 216
	}

	public private NetAddress PrivateEndPoint
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public private NetAddress PublicEndPoint
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		private set { } //Length: 20
	}

	private static StunResult() { }

	private StunResult(NetAddress publicEndPoint = null, NetAddress privateEndPoint = null) { }

	public static StunResult BuildStunResult(NetAddress publicEndPoint1, NetAddress publicEndPoint2, NetAddress privateEndPoint) { }

	public bool get_IsValid() { }

	[CompilerGenerated]
	public NetAddress get_PrivateEndPoint() { }

	[CompilerGenerated]
	public NetAddress get_PublicEndPoint() { }

	[CompilerGenerated]
	private void set_PrivateEndPoint(NetAddress value) { }

	[CompilerGenerated]
	private void set_PublicEndPoint(NetAddress value) { }

	public virtual string ToString() { }

}

