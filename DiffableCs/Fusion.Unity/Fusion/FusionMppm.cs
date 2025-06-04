namespace Fusion;

public class FusionMppm
{
	public static readonly FusionMppmStatus Status; //Field offset: 0x0
	[CanBeNull]
	public static readonly FusionMppm MainEditor; //Field offset: 0x8

	private FusionMppm() { }

	[Conditional("FUSION_ENABLE_MPPM")]
	[Obsolete("Use FusionMppm.Broadcaster?.Send instead")]
	public static void Broadcast(T data) { }

	[Conditional("UNITY_EDITOR")]
	public void Send(T data) { }

}

