namespace UnityEngine.Animations.Rigging;

internal static class RigUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FieldInfo, Boolean> <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ExtractNestedPropertyType>b__6_0(FieldInfo info) { }

	}

	private struct RigSyncSceneToStreamData : IAnimationJobData, IRigSyncSceneToStreamData
	{
		[CompilerGenerated]
		private Transform[] <syncableTransforms>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private SyncableProperties[] <syncableProperties>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Boolean[] <rigStates>k__BackingField; //Field offset: 0x10
		private readonly bool m_IsValid; //Field offset: 0x18

		public override Boolean[] rigStates
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public private override SyncableProperties[] syncableProperties
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public private override Transform[] syncableTransforms
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public RigSyncSceneToStreamData(Transform[] transforms, SyncableProperties[] properties, int rigCount) { }

		[CompilerGenerated]
		[IsReadOnly]
		public override Boolean[] get_rigStates() { }

		[CompilerGenerated]
		[IsReadOnly]
		public override SyncableProperties[] get_syncableProperties() { }

		[CompilerGenerated]
		[IsReadOnly]
		public override Transform[] get_syncableTransforms() { }

		[CompilerGenerated]
		public void set_rigStates(Boolean[] value) { }

		[CompilerGenerated]
		private void set_syncableProperties(SyncableProperties[] value) { }

		[CompilerGenerated]
		private void set_syncableTransforms(Transform[] value) { }

		private static Int32[] UniqueTransformIndices(Transform[] transforms) { }

		private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

		private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

	}

	internal static readonly Dictionary<Type, PropertyDescriptor> s_SupportedPropertyTypeToDescriptor; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly IAnimationJobBinder <syncSceneToStreamBinder>k__BackingField; //Field offset: 0x8

	public static IAnimationJobBinder syncSceneToStreamBinder
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	private static RigUtils() { }

	public static IAnimationJob[] CreateAnimationJobs(Animator animator, IRigConstraint[] constraints) { }

	internal static IAnimationJobData CreateSyncSceneToStreamData(Animator animator, IList<IRigLayer> layers) { }

	public static void DestroyAnimationJobs(IRigConstraint[] constraints, IAnimationJob[] jobs) { }

	private static void ExtractAllSyncableData(Animator animator, IList<IRigLayer> layers, out List<Transform>& syncableTransforms, out List<SyncableProperties>& syncableProperties) { }

	private static bool ExtractNestedPropertyType(Animator animator, FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties, string namePrefix = "") { }

	private static bool ExtractPropertyType(FieldInfo field, object data, List<Property> syncableProperties, string namePrefix = "") { }

	private static bool ExtractTransformType(Animator animator, FieldInfo field, object data, List<Transform> syncableTransforms) { }

	private static bool ExtractWeightedTransforms(Animator animator, FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties) { }

	[CompilerGenerated]
	public static IAnimationJobBinder get_syncSceneToStreamBinder() { }

	public static IRigConstraint[] GetConstraints(Rig rig) { }

	private static Transform[] GetSyncableRigTransforms(Animator animator) { }

}

