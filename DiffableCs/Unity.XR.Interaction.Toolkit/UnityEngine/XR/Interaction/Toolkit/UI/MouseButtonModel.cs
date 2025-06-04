namespace UnityEngine.XR.Interaction.Toolkit.UI;

public struct MouseButtonModel
{
	public struct ImplementationData
	{
		[CompilerGenerated]
		private bool <isDragging>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private float <pressedTime>k__BackingField; //Field offset: 0x4
		[CompilerGenerated]
		private Vector2 <pressedPosition>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private RaycastResult <pressedRaycast>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private GameObject <pressedGameObject>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private GameObject <pressedGameObjectRaw>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private GameObject <draggedGameObject>k__BackingField; //Field offset: 0x70

		public GameObject draggedGameObject
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
		public bool get_isDragging() { }

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
		public void set_isDragging(bool value) { }

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
	private ButtonDeltaState <lastFrameDelta>k__BackingField; //Field offset: 0x0
	private bool m_IsDown; //Field offset: 0x4
	private ImplementationData m_ImplementationData; //Field offset: 0x8

	public bool isDown
	{
		 get { } //Length: 8
		 set { } //Length: 48
	}

	internal ButtonDeltaState lastFrameDelta
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public void CopyFrom(PointerEventData eventData) { }

	public void CopyTo(PointerEventData eventData) { }

	public bool get_isDown() { }

	[CompilerGenerated]
	[IsReadOnly]
	internal ButtonDeltaState get_lastFrameDelta() { }

	public void OnFrameFinished() { }

	public void Reset() { }

	public void set_isDown(bool value) { }

	[CompilerGenerated]
	private void set_lastFrameDelta(ButtonDeltaState value) { }

}

