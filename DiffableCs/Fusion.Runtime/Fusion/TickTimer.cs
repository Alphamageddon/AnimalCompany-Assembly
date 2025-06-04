namespace Fusion;

[NetworkStructWeaved(1)]
public struct TickTimer : INetworkStruct
{
	private int _target; //Field offset: 0x0

	public bool IsRunning
	{
		 get { } //Length: 16
	}

	public static TickTimer None
	{
		 get { } //Length: 8
	}

	public Nullable<Int32> TargetTick
	{
		 get { } //Length: 100
	}

	public static TickTimer CreateFromSeconds(NetworkRunner runner, float delayInSeconds) { }

	public static TickTimer CreateFromTicks(NetworkRunner runner, int ticks) { }

	public bool Expired(NetworkRunner runner) { }

	public bool ExpiredOrNotRunning(NetworkRunner runner) { }

	public bool get_IsRunning() { }

	public static TickTimer get_None() { }

	public Nullable<Int32> get_TargetTick() { }

	public Nullable<Int32> RemainingTicks(NetworkRunner runner) { }

	public Nullable<Single> RemainingTime(NetworkRunner runner) { }

	public virtual string ToString() { }

}

