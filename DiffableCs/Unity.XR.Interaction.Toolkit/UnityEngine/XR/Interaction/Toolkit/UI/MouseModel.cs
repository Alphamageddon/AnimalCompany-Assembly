namespace UnityEngine.XR.Interaction.Toolkit.UI;

internal struct MouseModel
{
	public struct InternalData
	{
		[CompilerGenerated]
		private List<GameObject> <hoverTargets>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private GameObject <pointerTarget>k__BackingField; //Field offset: 0x8

		public List<GameObject> hoverTargets
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public GameObject pointerTarget
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 1168
		}

		[CompilerGenerated]
		[IsReadOnly]
		public List<GameObject> get_hoverTargets() { }

		[CompilerGenerated]
		[IsReadOnly]
		public GameObject get_pointerTarget() { }

		public void Reset() { }

		[CompilerGenerated]
		public void set_hoverTargets(List<GameObject> value) { }

		[CompilerGenerated]
		public void set_pointerTarget(GameObject value) { }

	}

	[CompilerGenerated]
	private readonly int <pointerId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <changedThisFrame>k__BackingField; //Field offset: 0x4
	private int m_DisplayIndex; //Field offset: 0x8
	private Vector2 m_Position; //Field offset: 0xC
	[CompilerGenerated]
	private Vector2 <deltaPosition>k__BackingField; //Field offset: 0x14
	private Vector2 m_ScrollDelta; //Field offset: 0x1C
	private MouseButtonModel m_LeftButton; //Field offset: 0x28
	private MouseButtonModel m_RightButton; //Field offset: 0xA8
	private MouseButtonModel m_MiddleButton; //Field offset: 0x128
	private InternalData m_InternalData; //Field offset: 0x1A8

	public private bool changedThisFrame
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private Vector2 deltaPosition
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public int displayIndex
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public MouseButtonModel leftButton
	{
		 get { } //Length: 16
		 set { } //Length: 48
	}

	public bool leftButtonPressed
	{
		 set { } //Length: 84
	}

	public MouseButtonModel middleButton
	{
		 get { } //Length: 16
		 set { } //Length: 48
	}

	public bool middleButtonPressed
	{
		 set { } //Length: 84
	}

	public int pointerId
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public Vector2 position
	{
		 get { } //Length: 8
		 set { } //Length: 68
	}

	public MouseButtonModel rightButton
	{
		 get { } //Length: 16
		 set { } //Length: 48
	}

	public bool rightButtonPressed
	{
		 set { } //Length: 84
	}

	public Vector2 scrollDelta
	{
		 get { } //Length: 8
		 set { } //Length: 56
	}

	public MouseModel(int pointerId) { }

	public void CopyFrom(PointerEventData eventData) { }

	public void CopyTo(PointerEventData eventData) { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_changedThisFrame() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector2 get_deltaPosition() { }

	public int get_displayIndex() { }

	public MouseButtonModel get_leftButton() { }

	public MouseButtonModel get_middleButton() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_pointerId() { }

	public Vector2 get_position() { }

	public MouseButtonModel get_rightButton() { }

	public Vector2 get_scrollDelta() { }

	public void OnFrameFinished() { }

	[CompilerGenerated]
	private void set_changedThisFrame(bool value) { }

	[CompilerGenerated]
	private void set_deltaPosition(Vector2 value) { }

	public void set_displayIndex(int value) { }

	public void set_leftButton(MouseButtonModel value) { }

	public void set_leftButtonPressed(bool value) { }

	public void set_middleButton(MouseButtonModel value) { }

	public void set_middleButtonPressed(bool value) { }

	public void set_position(Vector2 value) { }

	public void set_rightButton(MouseButtonModel value) { }

	public void set_rightButtonPressed(bool value) { }

	public void set_scrollDelta(Vector2 value) { }

}

