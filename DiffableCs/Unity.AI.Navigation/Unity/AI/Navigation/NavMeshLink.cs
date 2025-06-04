namespace Unity.AI.Navigation;

[AddComponentMenu("Navigation/NavMeshLink", 33)]
[DefaultExecutionOrder(-101)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshLink.html")]
public class NavMeshLink : MonoBehaviour
{
	private static readonly List<NavMeshLink> s_Tracked; //Field offset: 0x0
	[SerializeField]
	private int m_AgentTypeID; //Field offset: 0x20
	[SerializeField]
	private Vector3 m_StartPoint; //Field offset: 0x24
	[SerializeField]
	private Vector3 m_EndPoint; //Field offset: 0x30
	[SerializeField]
	private float m_Width; //Field offset: 0x3C
	[SerializeField]
	private int m_CostModifier; //Field offset: 0x40
	[SerializeField]
	private bool m_Bidirectional; //Field offset: 0x44
	[SerializeField]
	private bool m_AutoUpdatePosition; //Field offset: 0x45
	[SerializeField]
	private int m_Area; //Field offset: 0x48
	private NavMeshLinkInstance m_LinkInstance; //Field offset: 0x4C
	private Vector3 m_LastPosition; //Field offset: 0x50
	private Quaternion m_LastRotation; //Field offset: 0x5C

	public int agentTypeID
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	public int area
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	public bool autoUpdate
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool bidirectional
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public int costModifier
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	public Vector3 endPoint
	{
		 get { } //Length: 12
		 set { } //Length: 40
	}

	public Vector3 startPoint
	{
		 get { } //Length: 12
		 set { } //Length: 40
	}

	public float width
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	private static NavMeshLink() { }

	public NavMeshLink() { }

	private void AddLink() { }

	private static void AddTracking(NavMeshLink link) { }

	public int get_agentTypeID() { }

	public int get_area() { }

	public bool get_autoUpdate() { }

	public bool get_bidirectional() { }

	public int get_costModifier() { }

	public Vector3 get_endPoint() { }

	public Vector3 get_startPoint() { }

	public float get_width() { }

	private bool HasTransformChanged() { }

	private void OnDidApplyAnimationProperties() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private static void RemoveTracking(NavMeshLink link) { }

	public void set_agentTypeID(int value) { }

	public void set_area(int value) { }

	public void set_autoUpdate(bool value) { }

	public void set_bidirectional(bool value) { }

	public void set_costModifier(int value) { }

	public void set_endPoint(Vector3 value) { }

	public void set_startPoint(Vector3 value) { }

	public void set_width(float value) { }

	private void SetAutoUpdate(bool value) { }

	public void UpdateLink() { }

	private static void UpdateTrackedInstances() { }

}

