namespace Fusion;

internal class SimulationBehaviourUpdater
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__12_0; //Field offset: 0x8
		public static Comparison<BehaviourList> <>9__12_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<Type, BehaviourList>, String> <>9__24_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <BuildTypeOrder>b__12_0(Type x) { }

		internal int <BuildTypeOrder>b__12_1(BehaviourList a, BehaviourList b) { }

		internal string <FindList>b__24_0(KeyValuePair<Type, BehaviourList> x) { }

	}

	public class BehaviourList : ILogDumpable
	{
		public Type Type; //Field offset: 0x10
		public int ExecutionOrder; //Field offset: 0x18
		public SimulationModes Modes; //Field offset: 0x1C
		public SimulationStages Stages; //Field offset: 0x20
		public Topologies Topologies; //Field offset: 0x24
		public SimulationBehaviour Head; //Field offset: 0x28
		public SimulationBehaviour Tail; //Field offset: 0x30
		public int LockCount; //Field offset: 0x38
		public List<SimulationBehaviour> PendingRemovals; //Field offset: 0x40
		public BehaviourStatisticsManager BehaviourStats; //Field offset: 0x48

		public BehaviourList() { }

		public void AddAfter(SimulationBehaviour item, SimulationBehaviour after) { }

		public void AddFirst(SimulationBehaviour item) { }

		public void AddLast(SimulationBehaviour item) { }

		private override void Fusion.ILogDumpable.Dump(StringBuilder builder) { }

		public bool IsInList(SimulationBehaviour item) { }

		public void PendingRemove(SimulationBehaviour item) { }

		public void Remove(SimulationBehaviour item) { }

		public void RemoveAllPending() { }

	}

	private readonly Dictionary<Type, BehaviourList> _byTypeLookup; //Field offset: 0x10
	private readonly Dictionary<Type, ValueTuple`2<SimulationBehaviour[], Type[]>> _byTypeHierarchy; //Field offset: 0x18
	private readonly List<BehaviourList> _inOrderList; //Field offset: 0x20
	private readonly Dictionary<Type, List`1<BehaviourList>> _inOrderByInterfaceList; //Field offset: 0x28
	private readonly HashSet<Type> _behavioursChecked; //Field offset: 0x30
	private readonly NetworkProjectConfig _config; //Field offset: 0x38

	private static Type[] CallbackInterfacesDefualts
	{
		private get { } //Length: 1596
	}

	public SimulationBehaviourUpdater(NetworkProjectConfig config) { }

	public void AddBehaviour(SimulationBehaviour behaviour, bool skipFirstCall) { }

	public void AddObject(NetworkRunner runner, NetworkObject obj, bool skipFirstCall, bool isInSimulation) { }

	private void AddType(Type type, ValueTuple<SimulationModes, SimulationStages, Topologies> attr) { }

	public void BuildTypeOrder(Type[] customCallbackInterfaces) { }

	private void CheckSimulationBehaviourForNetworkedAttribute(Type type) { }

	private BehaviourList FindList(Type type) { }

	[Conditional("DEBUG")]
	public void FinishBehaviourStatisticsPendingSnapshot() { }

	private static Type[] get_CallbackInterfacesDefualts() { }

	public void GetAllSimulationBehaviours(List<SimulationBehaviour> allSb) { }

	public int GetCallbackCount(Type type) { }

	public SimulationBehaviourListScope GetCallbackHead(Type type, int index, out SimulationBehaviour head) { }

	private int GetExecutionOrder(Type type) { }

	private static ValueTuple<SimulationModes, SimulationStages, Topologies> GetSimulationFlags(Type type) { }

	public SimulationBehaviour[] GetTypeHeads(Type type) { }

	public void InvokeFixedUpdateNetwork(SimulationStages stage, SimulationModes mode, Topologies topology) { }

	public void InvokeRender() { }

	public void RemoveBehaviour(SimulationBehaviour behaviour) { }

	private static List<Type> Scanlibrary() { }

	public bool TryGetBehaviourStatisticsSnapshot(Type behaviourType, out BehaviourStatisticsSnapshot behaviourStatisticsSnapshot) { }

}

