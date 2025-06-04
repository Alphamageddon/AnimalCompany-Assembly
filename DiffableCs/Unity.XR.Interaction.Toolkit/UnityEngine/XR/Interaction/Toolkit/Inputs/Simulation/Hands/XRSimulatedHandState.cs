namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.Hands;

internal struct XRSimulatedHandState
{
	[CompilerGenerated]
	private Vector3 <position>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Quaternion <rotation>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private Vector3 <euler>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private HandExpressionName <expressionName>k__BackingField; //Field offset: 0x28

	public Vector3 euler
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public HandExpressionName expressionName
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Vector3 position
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Quaternion rotation
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_euler() { }

	[CompilerGenerated]
	[IsReadOnly]
	public HandExpressionName get_expressionName() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_position() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Quaternion get_rotation() { }

	public void Reset() { }

	[CompilerGenerated]
	public void set_euler(Vector3 value) { }

	[CompilerGenerated]
	public void set_expressionName(HandExpressionName value) { }

	[CompilerGenerated]
	public void set_position(Vector3 value) { }

	[CompilerGenerated]
	public void set_rotation(Quaternion value) { }

}

