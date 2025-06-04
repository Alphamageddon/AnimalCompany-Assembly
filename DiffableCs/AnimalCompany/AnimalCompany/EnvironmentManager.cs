namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class EnvironmentManager : NetworkBehaviour
{
	private static EnvironmentManager _instance; //Field offset: 0x0
	private static Dictionary<Int32, List`1<NavPoint>> _navPoints; //Field offset: 0x8
	private static NavPoint[] _allNavPoints; //Field offset: 0x10
	[SerializeField]
	private NavMeshSurface _navMeshSurface; //Field offset: 0x80
	[SerializeField]
	private bool _buildNavMeshOnStart; //Field offset: 0x88
	private WaitForSeconds _waitForThirtySeconds; //Field offset: 0x90

	public static EnvironmentManager instance
	{
		 get { } //Length: 88
	}

	private static EnvironmentManager() { }

	public EnvironmentManager() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public static EnvironmentManager get_instance() { }

	private void OnDestroy() { }

	public virtual void Spawned() { }

}

