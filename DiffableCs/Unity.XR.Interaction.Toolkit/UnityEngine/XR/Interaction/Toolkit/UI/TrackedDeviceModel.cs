namespace UnityEngine.XR.Interaction.Toolkit.UI;

public struct TrackedDeviceModel
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
		private Vector2 <position>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private Vector2 <pressedPosition>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private Vector3 <pressedWorldPosition>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private RaycastResult <pressedRaycast>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private GameObject <pressedGameObject>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		private GameObject <pressedGameObjectRaw>k__BackingField; //Field offset: 0x90
		[CompilerGenerated]
		private GameObject <draggedGameObject>k__BackingField; //Field offset: 0x98

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

		public Vector2 position
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

		public Vector3 pressedWorldPosition
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 12
			[CompilerGenerated]
			 set { } //Length: 12
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
		public Vector2 get_position() { }

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

		[CompilerGenerated]
		[IsReadOnly]
		public Vector3 get_pressedWorldPosition() { }

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
		public void set_position(Vector2 value) { }

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

		[CompilerGenerated]
		public void set_pressedWorldPosition(Vector3 value) { }

	}

	private const float k_DefaultMaxRaycastDistance = 1000; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly TrackedDeviceModel <invalid>k__BackingField; //Field offset: 0x0
	private ImplementationData m_ImplementationData; //Field offset: 0x0
	[CompilerGenerated]
	private readonly int <pointerId>k__BackingField; //Field offset: 0xA0
	private bool m_SelectDown; //Field offset: 0xA4
	[CompilerGenerated]
	private ButtonDeltaState <selectDelta>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <changedThisFrame>k__BackingField; //Field offset: 0xAC
	private Vector3 m_Position; //Field offset: 0xB0
	[CompilerGenerated]
	private Func<Vector3> <positionGetter>k__BackingField; //Field offset: 0xC0
	private Quaternion m_Orientation; //Field offset: 0xC8
	private List<Vector3> m_RaycastPoints; //Field offset: 0xD8
	[CompilerGenerated]
	private RaycastResult <currentRaycast>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private int <currentRaycastEndpointIndex>k__BackingField; //Field offset: 0x130
	private LayerMask m_RaycastLayerMask; //Field offset: 0x134
	private Vector2 m_ScrollDelta; //Field offset: 0x138
	private float m_PokeDepth; //Field offset: 0x140
	private UIInteractionType m_InteractionType; //Field offset: 0x144
	[CompilerGenerated]
	private GameObject <selectableObject>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private bool <isScrollable>k__BackingField; //Field offset: 0x150
	private float m_MaxRaycastDistance; //Field offset: 0x154

	public private bool changedThisFrame
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private RaycastResult currentRaycast
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 16
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private int currentRaycastEndpointIndex
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal ImplementationData implementationData
	{
		internal get { } //Length: 16
	}

	internal UIInteractionType interactionType
	{
		internal get { } //Length: 8
		internal set { } //Length: 108
	}

	internal static TrackedDeviceModel invalid
	{
		[CompilerGenerated]
		internal get { } //Length: 96
	}

	public bool isScrollable
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[Obsolete("maxRaycastDistance has been deprecated. Its value was unused, calling this property is unnecessary and should be removed.")]
	public float maxRaycastDistance
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Quaternion orientation
	{
		 get { } //Length: 12
		 set { } //Length: 180
	}

	public int pointerId
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
	}

	internal float pokeDepth
	{
		internal get { } //Length: 8
		internal set { } //Length: 116
	}

	public Vector3 position
	{
		 get { } //Length: 116
		 set { } //Length: 180
	}

	internal Func<Vector3> positionGetter
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public LayerMask raycastLayerMask
	{
		 get { } //Length: 8
		 set { } //Length: 132
	}

	public List<Vector3> raycastPoints
	{
		 get { } //Length: 8
		 set { } //Length: 152
	}

	public Vector2 scrollDelta
	{
		 get { } //Length: 12
		 set { } //Length: 156
	}

	public bool select
	{
		 get { } //Length: 8
		 set { } //Length: 180
	}

	public GameObject selectableObject
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public private ButtonDeltaState selectDelta
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static TrackedDeviceModel() { }

	public TrackedDeviceModel(int pointerId) { }

	public void CopyFrom(TrackedDeviceEventData eventData) { }

	public void CopyTo(TrackedDeviceEventData eventData) { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_changedThisFrame() { }

	[CompilerGenerated]
	[IsReadOnly]
	public RaycastResult get_currentRaycast() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_currentRaycastEndpointIndex() { }

	internal ImplementationData get_implementationData() { }

	internal UIInteractionType get_interactionType() { }

	[CompilerGenerated]
	internal static TrackedDeviceModel get_invalid() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_isScrollable() { }

	public float get_maxRaycastDistance() { }

	public Quaternion get_orientation() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_pointerId() { }

	internal float get_pokeDepth() { }

	public Vector3 get_position() { }

	[CompilerGenerated]
	[IsReadOnly]
	internal Func<Vector3> get_positionGetter() { }

	public LayerMask get_raycastLayerMask() { }

	public List<Vector3> get_raycastPoints() { }

	public Vector2 get_scrollDelta() { }

	public bool get_select() { }

	[CompilerGenerated]
	[IsReadOnly]
	public GameObject get_selectableObject() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ButtonDeltaState get_selectDelta() { }

	public void OnFrameFinished() { }

	public void Reset(bool resetImplementation = true) { }

	[CompilerGenerated]
	private void set_changedThisFrame(bool value) { }

	[CompilerGenerated]
	private void set_currentRaycast(RaycastResult value) { }

	[CompilerGenerated]
	private void set_currentRaycastEndpointIndex(int value) { }

	internal void set_interactionType(UIInteractionType value) { }

	[CompilerGenerated]
	public void set_isScrollable(bool value) { }

	public void set_maxRaycastDistance(float value) { }

	public void set_orientation(Quaternion value) { }

	internal void set_pokeDepth(float value) { }

	public void set_position(Vector3 value) { }

	[CompilerGenerated]
	internal void set_positionGetter(Func<Vector3> value) { }

	public void set_raycastLayerMask(LayerMask value) { }

	public void set_raycastPoints(List<Vector3> value) { }

	public void set_scrollDelta(Vector2 value) { }

	public void set_select(bool value) { }

	[CompilerGenerated]
	public void set_selectableObject(GameObject value) { }

	[CompilerGenerated]
	private void set_selectDelta(ButtonDeltaState value) { }

}

