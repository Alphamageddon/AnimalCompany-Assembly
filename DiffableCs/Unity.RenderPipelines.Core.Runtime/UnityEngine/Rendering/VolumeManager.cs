namespace UnityEngine.Rendering;

public sealed class VolumeManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ValueTuple`2<String, Type>, String> <>9__12_0; //Field offset: 0x8
		public static Func<Type, Boolean> <>9__29_0; //Field offset: 0x10
		public static Predicate<Volume> <>9__42_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal VolumeManager <.cctor>b__46_0() { }

		internal string <FilterVolumeComponentTypes>b__12_0(ValueTuple<String, Type> i) { }

		internal bool <GetVolumes>b__42_0(Volume v) { }

		internal bool <ReloadBaseTypes>b__29_0(Type t) { }

	}

	private static readonly Lazy<VolumeManager> s_Instance; //Field offset: 0x0
	private const int k_MaxLayerCount = 32; //Field offset: 0x0
	private static readonly Dictionary<Type, List`1<ValueTuple`2<String, Type>>> s_SupportedVolumeComponentsForRenderPipeline; //Field offset: 0x8
	[CompilerGenerated]
	private VolumeStack <stack>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Type[] <baseComponentTypeArray>k__BackingField; //Field offset: 0x18
	private readonly Dictionary<Int32, List`1<Volume>> m_SortedVolumes; //Field offset: 0x20
	private readonly List<Volume> m_Volumes; //Field offset: 0x28
	private readonly Dictionary<Int32, Boolean> m_SortNeeded; //Field offset: 0x30
	private readonly List<VolumeComponent> m_ComponentsDefaultState; //Field offset: 0x38
	private readonly List<Collider> m_TempColliders; //Field offset: 0x40
	private VolumeStack m_DefaultStack; //Field offset: 0x48

	public private Type[] baseComponentTypeArray
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[Obsolete("Please use baseComponentTypeArray instead.")]
	public private IEnumerable<Type> baseComponentTypes
	{
		 get { } //Length: 8
		private set { } //Length: 92
	}

	public static VolumeManager instance
	{
		 get { } //Length: 120
	}

	public VolumeStack stack
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	private static VolumeManager() { }

	private VolumeManager() { }

	[Conditional("UNITY_EDITOR")]
	public void CheckBaseTypes() { }

	[Conditional("UNITY_EDITOR")]
	public void CheckStack(VolumeStack stack) { }

	private bool CheckUpdateRequired(VolumeStack stack) { }

	public VolumeStack CreateStack() { }

	public void DestroyStack(VolumeStack stack) { }

	private static List<ValueTuple`2<String, Type>> FilterVolumeComponentTypes(Type[] types, Type currentPipelineType) { }

	[CompilerGenerated]
	public Type[] get_baseComponentTypeArray() { }

	public IEnumerable<Type> get_baseComponentTypes() { }

	public static VolumeManager get_instance() { }

	[CompilerGenerated]
	public VolumeStack get_stack() { }

	internal VolumeComponent GetDefaultVolumeComponent(Type volumeComponentType) { }

	internal static List<ValueTuple`2<String, Type>> GetSupportedVolumeComponents(Type currentPipelineType) { }

	public Volume[] GetVolumes(LayerMask layerMask) { }

	private List<Volume> GrabVolumes(LayerMask mask) { }

	public bool IsComponentActiveInMask(LayerMask layerMask) { }

	private static bool IsVolumeRenderedByCamera(Volume volume, Camera camera) { }

	private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor) { }

	public void Register(Volume volume, int layer) { }

	private void ReloadBaseTypes() { }

	internal void ReplaceData(VolumeStack stack) { }

	public void ResetMainStack() { }

	[CompilerGenerated]
	private void set_baseComponentTypeArray(Type[] value) { }

	private void set_baseComponentTypes(IEnumerable<Type> value) { }

	[CompilerGenerated]
	public void set_stack(VolumeStack value) { }

	internal void SetLayerDirty(int layer) { }

	private static void SortByPriority(List<Volume> volumes) { }

	public void Unregister(Volume volume, int layer) { }

	public void Update(Transform trigger, LayerMask layerMask) { }

	public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask) { }

	internal void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer) { }

}

