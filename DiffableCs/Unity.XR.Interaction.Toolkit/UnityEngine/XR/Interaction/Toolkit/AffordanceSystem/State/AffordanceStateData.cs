namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;

[IsReadOnly]
public struct AffordanceStateData : IEquatable<AffordanceStateData>
{
	public const byte totalStateTransitionIncrements = 255; //Field offset: 0x0
	[CompilerGenerated]
	private readonly byte <stateIndex>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly byte <stateTransitionIncrement>k__BackingField; //Field offset: 0x1

	public byte stateIndex
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public float stateTransitionAmountFloat
	{
		 get { } //Length: 24
	}

	public byte stateTransitionIncrement
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public AffordanceStateData(byte stateIndex, float transitionAmount) { }

	public AffordanceStateData(byte stateIndex, byte transitionIncrement) { }

	public override bool Equals(AffordanceStateData other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public byte get_stateIndex() { }

	public float get_stateTransitionAmountFloat() { }

	[CompilerGenerated]
	public byte get_stateTransitionIncrement() { }

	public virtual int GetHashCode() { }

}

