namespace Photon.Voice;

[IsReadOnly]
public struct SendFrameParams
{
	[CompilerGenerated]
	private readonly bool <TargetMe>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Int32[] <TargetPlayers>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly byte <InterestGroup>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <Reliable>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private readonly bool <Encrypt>k__BackingField; //Field offset: 0x12

	public bool Encrypt
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public byte InterestGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool Reliable
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool TargetMe
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Int32[] TargetPlayers
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public SendFrameParams(bool targetMe, Int32[] targetPlayers, byte interestGroup, bool reliable, bool encrypt) { }

	[CompilerGenerated]
	public bool get_Encrypt() { }

	[CompilerGenerated]
	public byte get_InterestGroup() { }

	[CompilerGenerated]
	public bool get_Reliable() { }

	[CompilerGenerated]
	public bool get_TargetMe() { }

	[CompilerGenerated]
	public Int32[] get_TargetPlayers() { }

}

