namespace Fusion.Sockets;

public struct NetConfigNotify
{
	public int AckMaskBytes; //Field offset: 0x0
	public int AckForceCount; //Field offset: 0x4
	public double AckForceTimeout; //Field offset: 0x8
	public int WindowSize; //Field offset: 0x10
	public int SequenceBytes; //Field offset: 0x14

	public int AckMaskBits
	{
		 get { } //Length: 12
	}

	public static NetConfigNotify Defaults
	{
		 get { } //Length: 40
	}

	public int SequenceBounds
	{
		 get { } //Length: 12
	}

	public int get_AckMaskBits() { }

	public static NetConfigNotify get_Defaults() { }

	public int get_SequenceBounds() { }

}

