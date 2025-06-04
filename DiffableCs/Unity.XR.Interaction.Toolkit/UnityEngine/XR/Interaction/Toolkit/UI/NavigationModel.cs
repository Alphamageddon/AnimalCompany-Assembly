namespace UnityEngine.XR.Interaction.Toolkit.UI;

internal struct NavigationModel
{
	internal struct ImplementationData
	{
		[CompilerGenerated]
		private int <consecutiveMoveCount>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private MoveDirection <lastMoveDirection>k__BackingField; //Field offset: 0x4
		[CompilerGenerated]
		private float <lastMoveTime>k__BackingField; //Field offset: 0x8

		public int consecutiveMoveCount
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public MoveDirection lastMoveDirection
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public float lastMoveTime
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		[CompilerGenerated]
		[IsReadOnly]
		public int get_consecutiveMoveCount() { }

		[CompilerGenerated]
		[IsReadOnly]
		public MoveDirection get_lastMoveDirection() { }

		[CompilerGenerated]
		[IsReadOnly]
		public float get_lastMoveTime() { }

		public void Reset() { }

		[CompilerGenerated]
		public void set_consecutiveMoveCount(int value) { }

		[CompilerGenerated]
		public void set_lastMoveDirection(MoveDirection value) { }

		[CompilerGenerated]
		public void set_lastMoveTime(float value) { }

	}

	[CompilerGenerated]
	private Vector2 <move>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ButtonDeltaState <submitButtonDelta>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private ButtonDeltaState <cancelButtonDelta>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private ImplementationData <implementationData>k__BackingField; //Field offset: 0x10
	private bool m_SubmitButtonDown; //Field offset: 0x1C
	private bool m_CancelButtonDown; //Field offset: 0x1D

	internal ButtonDeltaState cancelButtonDelta
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool cancelButtonDown
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	internal ImplementationData implementationData
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 16
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public Vector2 move
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	internal ButtonDeltaState submitButtonDelta
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool submitButtonDown
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	[CompilerGenerated]
	[IsReadOnly]
	internal ButtonDeltaState get_cancelButtonDelta() { }

	public bool get_cancelButtonDown() { }

	[CompilerGenerated]
	[IsReadOnly]
	internal ImplementationData get_implementationData() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector2 get_move() { }

	[CompilerGenerated]
	[IsReadOnly]
	internal ButtonDeltaState get_submitButtonDelta() { }

	public bool get_submitButtonDown() { }

	public void OnFrameFinished() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_cancelButtonDelta(ButtonDeltaState value) { }

	public void set_cancelButtonDown(bool value) { }

	[CompilerGenerated]
	internal void set_implementationData(ImplementationData value) { }

	[CompilerGenerated]
	public void set_move(Vector2 value) { }

	[CompilerGenerated]
	private void set_submitButtonDelta(ButtonDeltaState value) { }

	public void set_submitButtonDown(bool value) { }

}

