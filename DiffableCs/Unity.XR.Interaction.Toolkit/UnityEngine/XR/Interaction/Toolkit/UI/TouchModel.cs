namespace UnityEngine.XR.Interaction.Toolkit.UI;

internal struct TouchModel
{
	public struct ImplementationData
	{
		[CompilerGenerated]
		private List<GameObject> <hoverTargets>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private GameObject <pointerTarget>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private bool <isDragging>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private float <pressedTime>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private Vector2 <pressedPosition>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private RaycastResult <pressedRaycast>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private GameObject <pressedGameObject>k__BackingField; //Field offset: 0x70
		[CompilerGenerated]
		private GameObject <pressedGameObjectRaw>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private GameObject <draggedGameObject>k__BackingField; //Field offset: 0x80

		public GameObject draggedGameObject
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public List<GameObject> hoverTargets
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public bool isDragging
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public GameObject pointerTarget
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public GameObject pressedGameObject
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public GameObject pressedGameObjectRaw
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public Vector2 pressedPosition
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public RaycastResult pressedRaycast
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 16
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public float pressedTime
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		[CompilerGenerated]
		[IsReadOnly]
		public GameObject get_draggedGameObject() { }

		[CompilerGenerated]
		[IsReadOnly]
		public List<GameObject> get_hoverTargets() { }

		[CompilerGenerated]
		[IsReadOnly]
		public bool get_isDragging() { }

		[CompilerGenerated]
		[IsReadOnly]
		public GameObject get_pointerTarget() { }

		[CompilerGenerated]
		[IsReadOnly]
		public GameObject get_pressedGameObject() { }

		[CompilerGenerated]
		[IsReadOnly]
		public GameObject get_pressedGameObjectRaw() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Vector2 get_pressedPosition() { }

		[CompilerGenerated]
		[IsReadOnly]
		public RaycastResult get_pressedRaycast() { }

		[CompilerGenerated]
		[IsReadOnly]
		public float get_pressedTime() { }

		public void Reset() { }

		[CompilerGenerated]
		public void set_draggedGameObject(GameObject value) { }

		[CompilerGenerated]
		public void set_hoverTargets(List<GameObject> value) { }

		[CompilerGenerated]
		public void set_isDragging(bool value) { }

		[CompilerGenerated]
		public void set_pointerTarget(GameObject value) { }

		[CompilerGenerated]
		public void set_pressedGameObject(GameObject value) { }

		[CompilerGenerated]
		public void set_pressedGameObjectRaw(GameObject value) { }

		[CompilerGenerated]
		public void set_pressedPosition(Vector2 value) { }

		[CompilerGenerated]
		public void set_pressedRaycast(RaycastResult value) { }

		[CompilerGenerated]
		public void set_pressedTime(float value) { }

	}

	[CompilerGenerated]
	private readonly int <pointerId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ButtonDeltaState <selectDelta>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private bool <changedThisFrame>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Vector2 <deltaPosition>k__BackingField; //Field offset: 0xC
	private TouchPhase m_SelectPhase; //Field offset: 0x14
	private Vector2 m_Position; //Field offset: 0x18
	private ImplementationData m_ImplementationData; //Field offset: 0x20

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

	public private ButtonDeltaState selectDelta
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public TouchPhase selectPhase
	{
		 get { } //Length: 8
		 set { } //Length: 68
	}

	public TouchModel(int pointerId) { }

	public void CopyFrom(PointerEventData eventData) { }

	public void CopyTo(PointerEventData eventData) { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_changedThisFrame() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector2 get_deltaPosition() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_pointerId() { }

	public Vector2 get_position() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ButtonDeltaState get_selectDelta() { }

	public TouchPhase get_selectPhase() { }

	public void OnFrameFinished() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_changedThisFrame(bool value) { }

	[CompilerGenerated]
	private void set_deltaPosition(Vector2 value) { }

	public void set_position(Vector2 value) { }

	[CompilerGenerated]
	private void set_selectDelta(ButtonDeltaState value) { }

	public void set_selectPhase(TouchPhase value) { }

}

