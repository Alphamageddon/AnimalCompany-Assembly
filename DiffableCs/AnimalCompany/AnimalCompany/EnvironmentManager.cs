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
                 get
                 {
                        if (_instance == null)
                                _instance = Object.FindObjectOfType<EnvironmentManager>();
                        return _instance;
                 }
        }

	private static EnvironmentManager() { }

	public EnvironmentManager() { }

        private void Awake()
        {
                if (_instance == null)
                        _instance = this;
                else if (_instance != this)
                {
                        Destroy(gameObject);
                        return;
                }

                _waitForThirtySeconds = new WaitForSeconds(30f);
                if (_buildNavMeshOnStart && _navMeshSurface != null)
                        _navMeshSurface.BuildNavMeshAsync();
        }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

        public static EnvironmentManager get_instance()
        {
                return instance;
        }

	private void OnDestroy() { }

	public virtual void Spawned() { }

}

