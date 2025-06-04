namespace Unity.AI.Navigation;

[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshModifierVolume.html")]
public class NavMeshModifierVolume : MonoBehaviour
{
	private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; //Field offset: 0x0
	[SerializeField]
	private Vector3 m_Size; //Field offset: 0x20
	[SerializeField]
	private Vector3 m_Center; //Field offset: 0x2C
	[SerializeField]
	private int m_Area; //Field offset: 0x38
	[SerializeField]
	private List<Int32> m_AffectedAgents; //Field offset: 0x40

	public static List<NavMeshModifierVolume> activeModifiers
	{
		 get { } //Length: 88
	}

	public int area
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Vector3 center
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public Vector3 size
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	private static NavMeshModifierVolume() { }

	public NavMeshModifierVolume() { }

	public bool AffectsAgentType(int agentTypeID) { }

	public static List<NavMeshModifierVolume> get_activeModifiers() { }

	public int get_area() { }

	public Vector3 get_center() { }

	public Vector3 get_size() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void set_area(int value) { }

	public void set_center(Vector3 value) { }

	public void set_size(Vector3 value) { }

}

