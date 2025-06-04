namespace UnityEngine.XR.Interaction.Toolkit.UI;

[AddComponentMenu("Event/Tracked Device Physics Raycaster", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.UI.TrackedDevicePhysicsRaycaster.html")]
public class TrackedDevicePhysicsRaycaster : BaseRaycaster
{
	private class RaycastHitArraySegment : IEnumerable<RaycastHit>, IEnumerable, IEnumerator<RaycastHit>, IEnumerator, IDisposable
	{
		private int m_Count; //Field offset: 0x10
		private readonly RaycastHit[] m_Hits; //Field offset: 0x18
		private int m_CurrentIndex; //Field offset: 0x20

		public int count
		{
			 get { } //Length: 8
			 set { } //Length: 8
		}

		public override RaycastHit Current
		{
			 get { } //Length: 68
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 112
		}

		public RaycastHitArraySegment(RaycastHit[] raycastHits, int count) { }

		public override void Dispose() { }

		public int get_count() { }

		public override RaycastHit get_Current() { }

		public override IEnumerator<RaycastHit> GetEnumerator() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		public void set_count(int value) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private sealed class RaycastHitComparer : IComparer<RaycastHit>
	{

		public RaycastHitComparer() { }

		public override int Compare(RaycastHit a, RaycastHit b) { }

	}

	private const int k_EverythingLayerMask = -1; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Specifies whether the ray cast should hit triggers.")]
	private QueryTriggerInteraction m_RaycastTriggerInteraction; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Layer mask used to filter events. Always combined with the ray cast mask of the UI interactor.")]
	private LayerMask m_EventMask; //Field offset: 0x2C
	[SerializeField]
	[Tooltip("The max number of intersections allowed. Value will be clamped to greater than 0.")]
	private int m_MaxRayIntersections; //Field offset: 0x30
	[SerializeField]
	[Tooltip("The event camera for this ray caster. The event camera is used to determine the screen position and display of the ray cast results.")]
	private Camera m_EventCamera; //Field offset: 0x38
	private bool m_HasWarnedEventCameraNull; //Field offset: 0x40
	private RaycastHit[] m_RaycastHits; //Field offset: 0x48
	private readonly RaycastHitComparer m_RaycastHitComparer; //Field offset: 0x50
	private RaycastHitArraySegment m_RaycastArrayWrapper; //Field offset: 0x58
	private readonly List<RaycastHit> m_RaycastResultsCache; //Field offset: 0x60
	private PhysicsScene m_LocalPhysicsScene; //Field offset: 0x68

	public virtual Camera eventCamera
	{
		 get { } //Length: 208
	}

	public LayerMask eventMask
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int maxRayIntersections
	{
		 get { } //Length: 8
		 set { } //Length: 112
	}

	public QueryTriggerInteraction raycastTriggerInteraction
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public TrackedDevicePhysicsRaycaster() { }

	protected virtual void Awake() { }

	public virtual Camera get_eventCamera() { }

	public LayerMask get_eventMask() { }

	public int get_maxRayIntersections() { }

	public QueryTriggerInteraction get_raycastTriggerInteraction() { }

	private bool PerformRaycast(Vector3 from, Vector3 to, LayerMask layerMask, Camera currentEventCamera, List<RaycastResult> resultAppendList) { }

	private void PerformRaycasts(TrackedDeviceEventData eventData, List<RaycastResult> resultAppendList) { }

	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	public void set_eventMask(LayerMask value) { }

	public void set_maxRayIntersections(int value) { }

	public void set_raycastTriggerInteraction(QueryTriggerInteraction value) { }

	public void SetEventCamera(Camera newEventCamera) { }

}

