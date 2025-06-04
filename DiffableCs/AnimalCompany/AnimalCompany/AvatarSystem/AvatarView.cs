namespace AnimalCompany.AvatarSystem;

public class AvatarView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AvatarAccessoryData, Boolean> <>9__40_2; //Field offset: 0x8
		public static Func<AvatarAccessoryData, AccessorySlotType> <>9__40_3; //Field offset: 0x10
		public static Func<IGrouping`2<AccessorySlotType, AvatarAccessoryData>, AccessorySlotType> <>9__40_4; //Field offset: 0x18
		public static Func<IGrouping`2<AccessorySlotType, AvatarAccessoryData>, AvatarAccessoryData> <>9__40_5; //Field offset: 0x20
		public static Func<AccessoryInstance, Boolean> <>9__40_6; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateAvatar>b__40_2(AvatarAccessoryData itemData) { }

		internal AccessorySlotType <UpdateAvatar>b__40_3(AvatarAccessoryData itemData) { }

		internal AccessorySlotType <UpdateAvatar>b__40_4(IGrouping<AccessorySlotType, AvatarAccessoryData> group) { }

		internal AvatarAccessoryData <UpdateAvatar>b__40_5(IGrouping<AccessorySlotType, AvatarAccessoryData> group) { }

		internal bool <UpdateAvatar>b__40_6(AccessoryInstance accessoryInstance) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass43_0
	{
		public BodyPartInstance partInstance; //Field offset: 0x0
		public AvatarRawBodyPartType partType; //Field offset: 0x8
		public AvatarView <>4__this; //Field offset: 0x10

	}

	[CompilerGenerated]
	private sealed class <EnumerateBodyRenderers>d__49 : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Renderer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public AvatarView <>4__this; //Field offset: 0x28
		private BodyPartInstance[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private BodyPartInstance <partInstance>5__4; //Field offset: 0x40

		private override Renderer System.Collections.Generic.IEnumerator<UnityEngine.Renderer>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <EnumerateBodyRenderers>d__49(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Renderer> System.Collections.Generic.IEnumerable<UnityEngine.Renderer>.GetEnumerator() { }

		[DebuggerHidden]
		private override Renderer System.Collections.Generic.IEnumerator<UnityEngine.Renderer>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <EnumerateRenderedMaterials>d__48 : IEnumerable<Material>, IEnumerable, IEnumerator<Material>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Material <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public AvatarView <>4__this; //Field offset: 0x28
		private BodyPartInstance[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private Material[] <>7__wrap3; //Field offset: 0x40
		private int <>7__wrap4; //Field offset: 0x48
		private AccessoryInstance[] <>7__wrap5; //Field offset: 0x50

		private override Material System.Collections.Generic.IEnumerator<UnityEngine.Material>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <EnumerateRenderedMaterials>d__48(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Material> System.Collections.Generic.IEnumerable<UnityEngine.Material>.GetEnumerator() { }

		[DebuggerHidden]
		private override Material System.Collections.Generic.IEnumerator<UnityEngine.Material>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class AccessoryInstance
	{
		public AccessorySlotType slotType; //Field offset: 0x10
		public GameObject obj; //Field offset: 0x18
		public AvatarAccessoryData data; //Field offset: 0x20
		public Material material; //Field offset: 0x28
		public MeshFilter meshFilter; //Field offset: 0x30
		public MeshRenderer meshRenderer; //Field offset: 0x38
		public SkinnedMeshRenderer skinnedMeshRenderer; //Field offset: 0x40
		public List<Object> createdAssets; //Field offset: 0x48

		public AccessoryInstance() { }

	}

	private class BodyPartInstance
	{
		public AvatarRawBodyPartType type; //Field offset: 0x10
		public GameObject obj; //Field offset: 0x18
		public MeshRenderer meshRenderer; //Field offset: 0x20
		public SkinnedMeshRenderer skinnedMeshRenderer; //Field offset: 0x28
		public Material[] materials; //Field offset: 0x30
		public AvatarBodyPartData data; //Field offset: 0x38
		public bool hidden; //Field offset: 0x40
		public bool meshCullingEnabled; //Field offset: 0x41
		public bool meshCulledCompletely; //Field offset: 0x42
		public List<Object> createdAssets; //Field offset: 0x48

		public bool rendererEnabled
		{
			 get { } //Length: 32
		}

		public BodyPartInstance() { }

		public bool get_rendererEnabled() { }

	}

	private static readonly Dictionary<AvatarRawBodyPartType, Bounds> AVATAR_BODY_PART_BOUNDS; //Field offset: 0x0
	[SerializeField]
	private AvatarSystemCatalog _catalog; //Field offset: 0x20
	[SerializeField]
	private AvatarArmature _armature; //Field offset: 0x28
	[SerializeField]
	private bool _enableCageDebug; //Field offset: 0x30
	private Color _primaryColor; //Field offset: 0x34
	private bool _isLocalAvatar; //Field offset: 0x44
	private bool _isInitialized; //Field offset: 0x45
	private Mesh _debugCageMesh; //Field offset: 0x48
	private AvatarBodyBoneData[] _baseArmatureBoneData; //Field offset: 0x50
	private Vector3[] _bodyCageVertices; //Field offset: 0x58
	private Transform[] _attachmentPoints; //Field offset: 0x60
	private BodyPartInstance[] _bodyPartInstances; //Field offset: 0x68
	private AccessoryInstance[] _accessoryInstances; //Field offset: 0x70
	private Transform _tailRootBone; //Field offset: 0x78
	private HashSet<Int32> _occludedCageTrianglesSet; //Field offset: 0x80
	private List<Int32> _triangleBuffer; //Field offset: 0x88
	private HashSet<Int32> _partiallyOccludedVerticesBuffer; //Field offset: 0x90
	public Action<AvatarRawBodyPartType> onCageMeshUpdated; //Field offset: 0x98
	private bool _isHeadOnly; //Field offset: 0xA0

	public AvatarArmature armature
	{
		 get { } //Length: 8
	}

	public IEnumerable<Renderer> bodyRenderers
	{
		 get { } //Length: 4
	}

	public Transform eyeLeft
	{
		 get { } //Length: 168
	}

	public Material eyeLeftMaterial
	{
		 get { } //Length: 232
	}

	public Transform eyeRight
	{
		 get { } //Length: 168
	}

	public Material eyeRightMaterial
	{
		 get { } //Length: 232
	}

	public SkinnedMeshRenderer headRenderer
	{
		 get { } //Length: 48
	}

	public IEnumerable<Material> materials
	{
		 get { } //Length: 4
	}

	private static AvatarView() { }

	public AvatarView() { }

	[CompilerGenerated]
	private bool <UpdateAvatar>b__40_0(StatePrimitive<String> itemID) { }

	[CompilerGenerated]
	private AvatarAccessoryData <UpdateAvatar>b__40_1(StatePrimitive<String> itemID) { }

	[CompilerGenerated]
	private void <UpdateBodyPart>g__Clear|43_0(ref <>c__DisplayClass43_0 unnamed_param_0) { }

	[IteratorStateMachine(typeof(<EnumerateBodyRenderers>d__49))]
	private IEnumerable<Renderer> EnumerateBodyRenderers() { }

	[IteratorStateMachine(typeof(<EnumerateRenderedMaterials>d__48))]
	private IEnumerable<Material> EnumerateRenderedMaterials() { }

	public AvatarArmature get_armature() { }

	public IEnumerable<Renderer> get_bodyRenderers() { }

	public Transform get_eyeLeft() { }

	public Material get_eyeLeftMaterial() { }

	public Transform get_eyeRight() { }

	public Material get_eyeRightMaterial() { }

	public SkinnedMeshRenderer get_headRenderer() { }

	public IEnumerable<Material> get_materials() { }

	private void InitInternal() { }

	public void SetColor(Color color) { }

	public void SetIsHeadOnly(bool isHeadOnly) { }

	public void SetIsLocalAvatar(bool isLocalAvatar) { }

	public bool TryGetCageVertexAtIndex(int index, out Vector3 cageVertex) { }

	private void UpdateAccessory(AccessoryInstance accessoryInstance, AvatarAccessoryData accessoryData, bool cageChanged, ref bool fittedAccessoryChanged) { }

	public void UpdateAvatar(UserAvatarState avatarState) { }

	private void UpdateBodyPart(AvatarRawBodyPartType partType, string itemID, ref bool bodyPartChanged, ref bool cageChanged, bool torsoCageChanged) { }

	private void UpdateBodyPartCulling(bool fittedAccessoryActive, HashSet<Int32> cageTrisOccludedByAccessory) { }

	private void UpdateCageMeshBoundaryForBodyPart(AvatarRawBodyPartType partType, AvatarBodyPartData data) { }

	private void UpdateCageMeshForBodyPart(Vector3[] baseCageMeshVertices, AvatarRawBodyPartType partType, AvatarBodyPartData data) { }

}

