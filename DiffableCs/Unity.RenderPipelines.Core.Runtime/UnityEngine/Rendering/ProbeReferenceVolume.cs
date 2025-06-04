namespace UnityEngine.Rendering;

public class ProbeReferenceVolume
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction<CellInfo> <>9__120_0; //Field offset: 0x8
		public static UnityAction<BlendingCellInfo> <>9__120_1; //Field offset: 0x10
		public static Func<Single> <>9__171_7; //Field offset: 0x18
		public static Func<Single> <>9__171_16; //Field offset: 0x20
		public static Func<Single> <>9__171_17; //Field offset: 0x28
		public static Func<Int32> <>9__171_22; //Field offset: 0x30
		public static Func<Int32> <>9__171_23; //Field offset: 0x38
		public static Func<Int32> <>9__171_26; //Field offset: 0x40
		public static Func<Int32> <>9__171_27; //Field offset: 0x48
		public static Func<Single> <>9__171_32; //Field offset: 0x50
		public static Func<Single> <>9__171_33; //Field offset: 0x58
		public static Func<Single> <>9__171_36; //Field offset: 0x60
		public static Func<Int32> <>9__171_39; //Field offset: 0x68
		public static Action<Int32> <>9__171_40; //Field offset: 0x70
		public static Func<Int32> <>9__171_41; //Field offset: 0x78
		public static Func<Int32> <>9__171_43; //Field offset: 0x80
		public static Action<Int32> <>9__171_44; //Field offset: 0x88
		public static Func<Int32> <>9__171_45; //Field offset: 0x90
		public static Func<Single> <>9__171_46; //Field offset: 0x98
		public static Action<Single> <>9__171_47; //Field offset: 0xA0
		public static Func<Single> <>9__171_48; //Field offset: 0xA8
		public static Func<Single> <>9__171_49; //Field offset: 0xB0
		public static Func<Single> <>9__171_54; //Field offset: 0xB8
		public static Action<Single> <>9__171_55; //Field offset: 0xC0
		public static Func<Single> <>9__171_56; //Field offset: 0xC8
		public static Func<Single> <>9__171_57; //Field offset: 0xD0

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__120_0(CellInfo x) { }

		internal void <.ctor>b__120_1(BlendingCellInfo x) { }

		internal float <RegisterDebug>b__171_16() { }

		internal float <RegisterDebug>b__171_17() { }

		internal int <RegisterDebug>b__171_22() { }

		internal int <RegisterDebug>b__171_23() { }

		internal int <RegisterDebug>b__171_26() { }

		internal int <RegisterDebug>b__171_27() { }

		internal float <RegisterDebug>b__171_32() { }

		internal float <RegisterDebug>b__171_33() { }

		internal float <RegisterDebug>b__171_36() { }

		internal int <RegisterDebug>b__171_39() { }

		internal void <RegisterDebug>b__171_40(int value) { }

		internal int <RegisterDebug>b__171_41() { }

		internal int <RegisterDebug>b__171_43() { }

		internal void <RegisterDebug>b__171_44(int value) { }

		internal int <RegisterDebug>b__171_45() { }

		internal float <RegisterDebug>b__171_46() { }

		internal void <RegisterDebug>b__171_47(float value) { }

		internal float <RegisterDebug>b__171_48() { }

		internal float <RegisterDebug>b__171_49() { }

		internal float <RegisterDebug>b__171_54() { }

		internal void <RegisterDebug>b__171_55(float value) { }

		internal float <RegisterDebug>b__171_56() { }

		internal float <RegisterDebug>b__171_57() { }

		internal float <RegisterDebug>b__171_7() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass171_0
	{
		public ProbeReferenceVolume <>4__this; //Field offset: 0x10
		public ProbeVolumeSystemParameters parameters; //Field offset: 0x18

		public <>c__DisplayClass171_0() { }

		internal bool <RegisterDebug>b__1() { }

		internal int <RegisterDebug>b__10() { }

		internal void <RegisterDebug>b__11(int value) { }

		internal int <RegisterDebug>b__12() { }

		internal void <RegisterDebug>b__13(int value) { }

		internal float <RegisterDebug>b__14() { }

		internal void <RegisterDebug>b__15(float value) { }

		internal float <RegisterDebug>b__18() { }

		internal void <RegisterDebug>b__19(float value) { }

		internal void <RegisterDebug>b__2(bool value) { }

		internal int <RegisterDebug>b__20() { }

		internal void <RegisterDebug>b__21(int v) { }

		internal int <RegisterDebug>b__24() { }

		internal void <RegisterDebug>b__25(int v) { }

		internal bool <RegisterDebug>b__28() { }

		internal void <RegisterDebug>b__29(bool value) { }

		internal bool <RegisterDebug>b__3() { }

		internal float <RegisterDebug>b__30() { }

		internal void <RegisterDebug>b__31(float value) { }

		internal float <RegisterDebug>b__34() { }

		internal void <RegisterDebug>b__35(float value) { }

		internal bool <RegisterDebug>b__37() { }

		internal void <RegisterDebug>b__38(bool value) { }

		internal void <RegisterDebug>b__4(bool value) { }

		internal float <RegisterDebug>b__5() { }

		internal int <RegisterDebug>b__50() { }

		internal void <RegisterDebug>b__51(int value) { }

		internal int <RegisterDebug>b__52() { }

		internal void <RegisterDebug>b__53(int value) { }

		internal void <RegisterDebug>b__6(float value) { }

		internal bool <RegisterDebug>b__8() { }

		internal void <RegisterDebug>b__9(bool value) { }

		internal void <RegisterDebug>g__RefreshDebug|0(Field<T> field, T value) { }

		internal void <RegisterDebug>g__RefreshScenarioNames|42(string guid) { }

	}

	[DebuggerDisplay("Index = {cellInfo.cell.index} Factor = {blendingFactor} Score = {streamingScore}")]
	public class BlendingCellInfo : IComparable<BlendingCellInfo>
	{
		public CellInfo cellInfo; //Field offset: 0x10
		public List<BrickChunkAlloc> chunkList; //Field offset: 0x18
		public float streamingScore; //Field offset: 0x20
		public float blendingFactor; //Field offset: 0x24
		public bool blending; //Field offset: 0x28

		public BlendingCellInfo() { }

		public void Clear() { }

		public override int CompareTo(BlendingCellInfo other) { }

		public void ForceReupload() { }

		public bool IsUpToDate() { }

		public void MarkUpToDate() { }

		public void Prioritize() { }

		public bool ShouldPrioritize() { }

		public bool ShouldReupload() { }

	}

	[DebuggerDisplay("Index = {index} position = {position}")]
	public class Cell
	{
		internal struct PerScenarioData
		{
			[CompilerGenerated]
			private NativeArray<UInt16> <shL0L1RxData>k__BackingField; //Field offset: 0x0
			[CompilerGenerated]
			private NativeArray<Byte> <shL1GL1RyData>k__BackingField; //Field offset: 0x10
			[CompilerGenerated]
			private NativeArray<Byte> <shL1BL1RzData>k__BackingField; //Field offset: 0x20
			[CompilerGenerated]
			private NativeArray<Byte> <shL2Data_0>k__BackingField; //Field offset: 0x30
			[CompilerGenerated]
			private NativeArray<Byte> <shL2Data_1>k__BackingField; //Field offset: 0x40
			[CompilerGenerated]
			private NativeArray<Byte> <shL2Data_2>k__BackingField; //Field offset: 0x50
			[CompilerGenerated]
			private NativeArray<Byte> <shL2Data_3>k__BackingField; //Field offset: 0x60

			public internal NativeArray<UInt16> shL0L1RxData
			{
				[CompilerGenerated]
				[IsReadOnly]
				 get { } //Length: 12
				[CompilerGenerated]
				internal set { } //Length: 8
			}

			public internal NativeArray<Byte> shL1BL1RzData
			{
				[CompilerGenerated]
				[IsReadOnly]
				 get { } //Length: 12
				[CompilerGenerated]
				internal set { } //Length: 8
			}

			public internal NativeArray<Byte> shL1GL1RyData
			{
				[CompilerGenerated]
				[IsReadOnly]
				 get { } //Length: 12
				[CompilerGenerated]
				internal set { } //Length: 8
			}

			public internal NativeArray<Byte> shL2Data_0
			{
				[CompilerGenerated]
				[IsReadOnly]
				 get { } //Length: 12
				[CompilerGenerated]
				internal set { } //Length: 8
			}

			public internal NativeArray<Byte> shL2Data_1
			{
				[CompilerGenerated]
				[IsReadOnly]
				 get { } //Length: 12
				[CompilerGenerated]
				internal set { } //Length: 8
			}

			public internal NativeArray<Byte> shL2Data_2
			{
				[CompilerGenerated]
				[IsReadOnly]
				 get { } //Length: 12
				[CompilerGenerated]
				internal set { } //Length: 8
			}

			public internal NativeArray<Byte> shL2Data_3
			{
				[CompilerGenerated]
				[IsReadOnly]
				 get { } //Length: 12
				[CompilerGenerated]
				internal set { } //Length: 8
			}

			[CompilerGenerated]
			[IsReadOnly]
			public NativeArray<UInt16> get_shL0L1RxData() { }

			[CompilerGenerated]
			[IsReadOnly]
			public NativeArray<Byte> get_shL1BL1RzData() { }

			[CompilerGenerated]
			[IsReadOnly]
			public NativeArray<Byte> get_shL1GL1RyData() { }

			[CompilerGenerated]
			[IsReadOnly]
			public NativeArray<Byte> get_shL2Data_0() { }

			[CompilerGenerated]
			[IsReadOnly]
			public NativeArray<Byte> get_shL2Data_1() { }

			[CompilerGenerated]
			[IsReadOnly]
			public NativeArray<Byte> get_shL2Data_2() { }

			[CompilerGenerated]
			[IsReadOnly]
			public NativeArray<Byte> get_shL2Data_3() { }

			[CompilerGenerated]
			internal void set_shL0L1RxData(NativeArray<UInt16> value) { }

			[CompilerGenerated]
			internal void set_shL1BL1RzData(NativeArray<Byte> value) { }

			[CompilerGenerated]
			internal void set_shL1GL1RyData(NativeArray<Byte> value) { }

			[CompilerGenerated]
			internal void set_shL2Data_0(NativeArray<Byte> value) { }

			[CompilerGenerated]
			internal void set_shL2Data_1(NativeArray<Byte> value) { }

			[CompilerGenerated]
			internal void set_shL2Data_2(NativeArray<Byte> value) { }

			[CompilerGenerated]
			internal void set_shL2Data_3(NativeArray<Byte> value) { }

		}

		public Vector3Int position; //Field offset: 0x10
		public int index; //Field offset: 0x1C
		public int probeCount; //Field offset: 0x20
		public int minSubdiv; //Field offset: 0x24
		public int maxSubdiv; //Field offset: 0x28
		public int indexChunkCount; //Field offset: 0x2C
		public int shChunkCount; //Field offset: 0x30
		public bool hasTwoScenarios; //Field offset: 0x34
		public ProbeVolumeSHBands shBands; //Field offset: 0x38
		[CompilerGenerated]
		private NativeArray<Brick> <bricks>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private NativeArray<Byte> <validityNeighMaskData>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		private NativeArray<Vector3> <probePositions>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private NativeArray<Single> <touchupVolumeInteraction>k__BackingField; //Field offset: 0x70
		[CompilerGenerated]
		private NativeArray<Vector3> <offsetVectors>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		private NativeArray<Single> <validity>k__BackingField; //Field offset: 0x90
		public PerScenarioData scenario0; //Field offset: 0xA0
		public PerScenarioData scenario1; //Field offset: 0x110

		public PerScenarioData bakingScenario
		{
			 get { } //Length: 16
		}

		public internal NativeArray<Brick> bricks
		{
			[CompilerGenerated]
			 get { } //Length: 12
			[CompilerGenerated]
			internal set { } //Length: 8
		}

		public internal NativeArray<Vector3> offsetVectors
		{
			[CompilerGenerated]
			 get { } //Length: 12
			[CompilerGenerated]
			internal set { } //Length: 8
		}

		public internal NativeArray<Vector3> probePositions
		{
			[CompilerGenerated]
			 get { } //Length: 12
			[CompilerGenerated]
			internal set { } //Length: 8
		}

		public internal NativeArray<Single> touchupVolumeInteraction
		{
			[CompilerGenerated]
			 get { } //Length: 12
			[CompilerGenerated]
			internal set { } //Length: 8
		}

		public internal NativeArray<Single> validity
		{
			[CompilerGenerated]
			 get { } //Length: 12
			[CompilerGenerated]
			internal set { } //Length: 8
		}

		public internal NativeArray<Byte> validityNeighMaskData
		{
			[CompilerGenerated]
			 get { } //Length: 12
			[CompilerGenerated]
			internal set { } //Length: 8
		}

		public Cell() { }

		public PerScenarioData get_bakingScenario() { }

		[CompilerGenerated]
		public NativeArray<Brick> get_bricks() { }

		[CompilerGenerated]
		public NativeArray<Vector3> get_offsetVectors() { }

		[CompilerGenerated]
		public NativeArray<Vector3> get_probePositions() { }

		[CompilerGenerated]
		public NativeArray<Single> get_touchupVolumeInteraction() { }

		[CompilerGenerated]
		public NativeArray<Single> get_validity() { }

		[CompilerGenerated]
		public NativeArray<Byte> get_validityNeighMaskData() { }

		[CompilerGenerated]
		internal void set_bricks(NativeArray<Brick> value) { }

		[CompilerGenerated]
		internal void set_offsetVectors(NativeArray<Vector3> value) { }

		[CompilerGenerated]
		internal void set_probePositions(NativeArray<Vector3> value) { }

		[CompilerGenerated]
		internal void set_touchupVolumeInteraction(NativeArray<Single> value) { }

		[CompilerGenerated]
		internal void set_validity(NativeArray<Single> value) { }

		[CompilerGenerated]
		internal void set_validityNeighMaskData(NativeArray<Byte> value) { }

	}

	[DebuggerDisplay("Index = {cell.index} Loaded = {loaded}")]
	public class CellInfo : IComparable<CellInfo>
	{
		public Cell cell; //Field offset: 0x10
		public BlendingCellInfo blendingCell; //Field offset: 0x18
		public List<BrickChunkAlloc> chunkList; //Field offset: 0x20
		public int flatIdxInCellIndices; //Field offset: 0x28
		public bool loaded; //Field offset: 0x2C
		public CellIndexUpdateInfo updateInfo; //Field offset: 0x30
		public bool indexUpdated; //Field offset: 0x60
		public CellIndexUpdateInfo tempUpdateInfo; //Field offset: 0x64
		public int sourceAssetInstanceID; //Field offset: 0x94
		public float streamingScore; //Field offset: 0x98
		public int referenceCount; //Field offset: 0x9C
		public CellInstancedDebugProbes debugProbes; //Field offset: 0xA0

		public CellInfo() { }

		public void Clear() { }

		public override int CompareTo(CellInfo other) { }

	}

	public class CellInstancedDebugProbes
	{
		public List<Matrix4x4[]> probeBuffers; //Field offset: 0x10
		public List<Matrix4x4[]> offsetBuffers; //Field offset: 0x18
		public List<MaterialPropertyBlock> props; //Field offset: 0x20

		public CellInstancedDebugProbes() { }

	}

	internal struct ExtraDataActionInput
	{

	}

	private struct InitInfo
	{
		public Vector3Int pendingMinCellPosition; //Field offset: 0x0
		public Vector3Int pendingMaxCellPosition; //Field offset: 0xC

	}

	public struct RefVolTransform
	{
		public Vector3 posWS; //Field offset: 0x0
		public Quaternion rot; //Field offset: 0xC
		public float scale; //Field offset: 0x1C

	}

	internal struct RuntimeResources
	{
		public ComputeBuffer index; //Field offset: 0x0
		public ComputeBuffer cellIndices; //Field offset: 0x8
		public RenderTexture L0_L1rx; //Field offset: 0x10
		public RenderTexture L1_G_ry; //Field offset: 0x18
		public RenderTexture L1_B_rz; //Field offset: 0x20
		public RenderTexture L2_0; //Field offset: 0x28
		public RenderTexture L2_1; //Field offset: 0x30
		public RenderTexture L2_2; //Field offset: 0x38
		public RenderTexture L2_3; //Field offset: 0x40
		public Texture3D Validity; //Field offset: 0x48

	}

	public struct Volume : IEquatable<Volume>
	{
		internal Vector3 corner; //Field offset: 0x0
		internal Vector3 X; //Field offset: 0xC
		internal Vector3 Y; //Field offset: 0x18
		internal Vector3 Z; //Field offset: 0x24
		internal float maxSubdivisionMultiplier; //Field offset: 0x30
		internal float minSubdivisionMultiplier; //Field offset: 0x34

		public Volume(Matrix4x4 trs, float maxSubdivision, float minSubdivision) { }

		public Volume(Vector3 corner, Vector3 X, Vector3 Y, Vector3 Z, float maxSubdivision = 1, float minSubdivision = 0) { }

		public Volume(Volume copy) { }

		public Volume(Bounds bounds) { }

		public Bounds CalculateAABB() { }

		public void CalculateCenterAndSize(out Vector3 center, out Vector3 size) { }

		public override bool Equals(Volume other) { }

		public virtual string ToString() { }

		public void Transform(Matrix4x4 trs) { }

	}

	internal static string defaultLightingScenario; //Field offset: 0x0
	private const int kProbesPerBatch = 511; //Field offset: 0x0
	private static ProbeReferenceVolume _instance; //Field offset: 0x8
	public static readonly string k_DebugPanelName; //Field offset: 0x10
	private bool m_IsInitialized; //Field offset: 0x10
	private bool m_SupportStreaming; //Field offset: 0x11
	private RefVolTransform m_Transform; //Field offset: 0x14
	private int m_MaxSubdivision; //Field offset: 0x34
	private ProbeBrickPool m_Pool; //Field offset: 0x38
	private ProbeBrickIndex m_Index; //Field offset: 0x40
	private ProbeCellIndices m_CellIndices; //Field offset: 0x48
	private ProbeBrickBlendingPool m_BlendingPool; //Field offset: 0x50
	private List<BrickChunkAlloc> m_TmpSrcChunks; //Field offset: 0x58
	private Single[] m_PositionOffsets; //Field offset: 0x60
	private Bounds m_CurrGlobalBounds; //Field offset: 0x68
	internal Dictionary<Int32, CellInfo> cells; //Field offset: 0x80
	private ObjectPool<CellInfo> m_CellInfoPool; //Field offset: 0x88
	private ObjectPool<BlendingCellInfo> m_BlendingCellInfoPool; //Field offset: 0x90
	private DataLocation m_TemporaryDataLocation; //Field offset: 0x98
	private int m_TemporaryDataLocationMemCost; //Field offset: 0xE8
	private int m_CurrentProbeVolumeChunkSizeInBricks; //Field offset: 0xEC
	internal ProbeVolumeSceneData sceneData; //Field offset: 0xF0
	private Vector3Int minLoadedCellPos; //Field offset: 0xF8
	private Vector3Int maxLoadedCellPos; //Field offset: 0x104
	public Action<ExtraDataActionInput> retrieveExtraDataAction; //Field offset: 0x110
	public Action checksDuringBakeAction; //Field offset: 0x118
	private bool m_BricksLoaded; //Field offset: 0x120
	private Dictionary<String, ProbeVolumeAsset> m_PendingAssetsToBeLoaded; //Field offset: 0x128
	private Dictionary<String, ProbeVolumeAsset> m_PendingAssetsToBeUnloaded; //Field offset: 0x130
	private Dictionary<String, ProbeVolumeAsset> m_ActiveAssets; //Field offset: 0x138
	private bool m_NeedLoadAsset; //Field offset: 0x140
	private bool m_ProbeReferenceVolumeInit; //Field offset: 0x141
	private bool m_EnabledBySRP; //Field offset: 0x142
	private InitInfo m_PendingInitInfo; //Field offset: 0x144
	private bool m_NeedsIndexRebuild; //Field offset: 0x15C
	private bool m_HasChangedIndex; //Field offset: 0x15D
	private int m_CBShaderID; //Field offset: 0x160
	private int m_NumberOfCellsLoadedPerFrame; //Field offset: 0x164
	private int m_NumberOfCellsBlendedPerFrame; //Field offset: 0x168
	private float m_TurnoverRate; //Field offset: 0x16C
	private ProbeVolumeTextureMemoryBudget m_MemoryBudget; //Field offset: 0x170
	private ProbeVolumeBlendingTextureMemoryBudget m_BlendingMemoryBudget; //Field offset: 0x174
	private ProbeVolumeSHBands m_SHBands; //Field offset: 0x178
	private float m_ProbeVolumesWeight; //Field offset: 0x17C
	internal bool clearAssetsOnVolumeClear; //Field offset: 0x180
	[CompilerGenerated]
	private List<ProbeVolumePerSceneData> <perSceneDataList>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private readonly ProbeVolumeDebug <probeVolumeDebug>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private readonly Color[] <subdivisionDebugColors>k__BackingField; //Field offset: 0x198
	private Widget[] m_DebugItems; //Field offset: 0x1A0
	private Mesh m_DebugMesh; //Field offset: 0x1A8
	private Material m_DebugMaterial; //Field offset: 0x1B0
	private Mesh m_DebugOffsetMesh; //Field offset: 0x1B8
	private Material m_DebugOffsetMaterial; //Field offset: 0x1C0
	private Plane[] m_DebugFrustumPlanes; //Field offset: 0x1C8
	private GUIContent[] m_DebugScenarioNames; //Field offset: 0x1D0
	private Int32[] m_DebugScenarioValues; //Field offset: 0x1D8
	private string m_DebugActiveSceneGUID; //Field offset: 0x1E0
	private string m_DebugActiveScenario; //Field offset: 0x1E8
	private EnumField m_DebugScenarioField; //Field offset: 0x1F0
	internal ProbeVolumeBakingProcessSettings bakingProcessSettings; //Field offset: 0x1F8
	internal Dictionary<Bounds, Brick[]> realtimeSubdivisionInfo; //Field offset: 0x228
	private bool m_MaxSubdivVisualizedIsMaxAvailable; //Field offset: 0x230
	private DynamicArray<CellInfo> m_LoadedCells; //Field offset: 0x238
	private DynamicArray<CellInfo> m_ToBeLoadedCells; //Field offset: 0x240
	private DynamicArray<CellInfo> m_TempCellToLoadList; //Field offset: 0x248
	private DynamicArray<CellInfo> m_TempCellToUnloadList; //Field offset: 0x250
	private DynamicArray<BlendingCellInfo> m_LoadedBlendingCells; //Field offset: 0x258
	private DynamicArray<BlendingCellInfo> m_ToBeLoadedBlendingCells; //Field offset: 0x260
	private DynamicArray<BlendingCellInfo> m_TempBlendingCellToLoadList; //Field offset: 0x268
	private DynamicArray<BlendingCellInfo> m_TempBlendingCellToUnloadList; //Field offset: 0x270
	private Vector3 m_FrozenCameraPosition; //Field offset: 0x278
	private bool m_HasRemainingCellsToBlend; //Field offset: 0x284

	internal bool enabledBySRP
	{
		internal get { } //Length: 8
	}

	internal bool enableScenarioBlending
	{
		internal get { } //Length: 104
	}

	internal Bounds globalBounds
	{
		internal get { } //Length: 20
		internal set { } //Length: 20
	}

	internal bool hasUnloadedCells
	{
		internal get { } //Length: 80
	}

	public static ProbeReferenceVolume instance
	{
		 get { } //Length: 88
	}

	public bool isInitialized
	{
		 get { } //Length: 8
	}

	public string lightingScenario
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public ProbeVolumeTextureMemoryBudget memoryBudget
	{
		 get { } //Length: 8
	}

	public int numberOfCellsBlendedPerFrame
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	internal int numberOfCellsLoadedPerFrame
	{
		internal get { } //Length: 8
	}

	internal List<ProbeVolumePerSceneData> perSceneDataList
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal ProbeVolumeDebug probeVolumeDebug
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	public float probeVolumesWeight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public float scenarioBlendingFactor
	{
		 get { } //Length: 28
		 set { } //Length: 32
	}

	public ProbeVolumeSHBands shBands
	{
		 get { } //Length: 8
	}

	public Color[] subdivisionDebugColors
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public float turnoverRate
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	private static ProbeReferenceVolume() { }

	private ProbeReferenceVolume() { }

	private bool AddBlendingBricks(BlendingCellInfo blendingCell) { }

	private bool AddBricks(CellInfo cellInfo, CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog) { }

	private void AddCell(Cell cell, int assetInstanceID) { }

	internal void AddPendingAssetLoading(ProbeVolumeAsset asset) { }

	internal void AddPendingAssetRemoval(ProbeVolumeAsset asset) { }

	private void AllocateTemporaryDataLocation() { }

	public void BlendLightingScenario(string otherScenario, float blendingFactor) { }

	internal float BrickSize(int subdivisionLevel) { }

	internal static int CellSize(int subdivisionLevel) { }

	private bool CheckCompatibilityWithCollection(ProbeVolumeAsset asset, Dictionary<String, ProbeVolumeAsset> collection) { }

	public void Cleanup() { }

	private void CleanupDebug() { }

	private void CleanupLoadedData() { }

	internal void Clear() { }

	private void ClearDebugData() { }

	private void ComputeCellCameraDistance(Vector3 cameraPosition, DynamicArray<CellInfo> cells) { }

	private void ComputeStreamingScoreForBlending(DynamicArray<BlendingCellInfo> cells, float worstScore) { }

	private CellInstancedDebugProbes CreateInstancedProbes(CellInfo cellInfo) { }

	public bool DataHasBeenLoaded() { }

	private void DebugCellIndexChanged(Field<T> field, T value) { }

	private void DrawProbeDebug(Camera camera) { }

	private int FindWorstBlendingCellToBeLoaded() { }

	internal void ForceSHBand(ProbeVolumeSHBands shBands) { }

	internal bool get_enabledBySRP() { }

	internal bool get_enableScenarioBlending() { }

	internal Bounds get_globalBounds() { }

	internal bool get_hasUnloadedCells() { }

	public static ProbeReferenceVolume get_instance() { }

	public bool get_isInitialized() { }

	public string get_lightingScenario() { }

	public ProbeVolumeTextureMemoryBudget get_memoryBudget() { }

	public int get_numberOfCellsBlendedPerFrame() { }

	internal int get_numberOfCellsLoadedPerFrame() { }

	[CompilerGenerated]
	internal List<ProbeVolumePerSceneData> get_perSceneDataList() { }

	[CompilerGenerated]
	internal ProbeVolumeDebug get_probeVolumeDebug() { }

	public float get_probeVolumesWeight() { }

	public float get_scenarioBlendingFactor() { }

	public ProbeVolumeSHBands get_shBands() { }

	[CompilerGenerated]
	public Color[] get_subdivisionDebugColors() { }

	public float get_turnoverRate() { }

	private bool GetCellIndexUpdate(Cell cell, out CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog) { }

	internal float GetDistanceBetweenProbes(int subdivisionLevel) { }

	internal int GetMaxSubdivision(float multiplier) { }

	internal int GetMaxSubdivision() { }

	internal int GetNumberOfBricksAtSubdiv(Vector3Int position, int minSubdiv, out Vector3Int minValidLocalIdxAtMaxRes, out Vector3Int sizeOfValidIndicesAtMaxRes) { }

	public RuntimeResources GetRuntimeResources() { }

	private List<BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, DataLocation dataLoc) { }

	internal RefVolTransform GetTransform() { }

	public int GetVideoMemoryCost() { }

	public void Initialize(in ProbeVolumeSystemParameters parameters) { }

	private void InitializeDebug(in ProbeVolumeSystemParameters parameters) { }

	private void InitProbeReferenceVolume(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget, ProbeVolumeSHBands shBands) { }

	internal void LoadAllCells() { }

	private void LoadAsset(ProbeVolumeAsset asset) { }

	internal bool LoadCell(CellInfo cellInfo, bool ignoreErrorLog = false) { }

	internal float MaxBrickSize() { }

	internal float MinBrickSize() { }

	internal float MinDistanceBetweenProbes() { }

	private void OnClearLightingdata() { }

	private void PerformPendingDeletion() { }

	private void PerformPendingIndexChangeAndInit() { }

	private void PerformPendingLoading() { }

	public void PerformPendingOperations() { }

	private void RecomputeMinMaxLoadedCellPos() { }

	private void RegisterDebug(ProbeVolumeSystemParameters parameters) { }

	internal void RegisterPerSceneData(ProbeVolumePerSceneData data) { }

	private void ReleaseBricks(CellInfo cellInfo) { }

	private void RemoveCell(Cell cell) { }

	internal void RemovePendingAsset(ProbeVolumeAsset asset) { }

	public void RenderDebug(Camera camera) { }

	internal void ResetDebugViewToMaxSubdiv() { }

	internal void ScenarioBlendingChanged(bool scenarioChanged) { }

	internal void set_globalBounds(Bounds value) { }

	public void set_lightingScenario(string value) { }

	public void set_numberOfCellsBlendedPerFrame(int value) { }

	[CompilerGenerated]
	private void set_perSceneDataList(List<ProbeVolumePerSceneData> value) { }

	public void set_probeVolumesWeight(float value) { }

	public void set_scenarioBlendingFactor(float value) { }

	public void set_turnoverRate(float value) { }

	public void SetEnableStateFromSRP(bool srpEnablesPV) { }

	internal void SetMaxSubdivision(int maxSubdivision) { }

	internal void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv) { }

	public void SetNumberOfCellsLoadedPerFrame(int numberOfCells) { }

	internal void SetTRS(Vector3 position, Quaternion rotation, float minBrickSize) { }

	private bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Plane[] frustumPlanes) { }

	private bool TryLoadBlendingCell(BlendingCellInfo blendingCell, DynamicArray<BlendingCellInfo> loadedCells) { }

	private bool TryLoadCell(CellInfo cellInfo, ref int shBudget, ref int indexBudget, DynamicArray<CellInfo> loadedCells) { }

	internal void UnloadAllBlendingCells() { }

	internal void UnloadAllCells() { }

	internal void UnloadBlendingCell(BlendingCellInfo blendingCell) { }

	private void UnloadBlendingCell(BlendingCellInfo blendingCell, DynamicArray<BlendingCellInfo> unloadedCells) { }

	internal void UnloadCell(CellInfo cellInfo) { }

	private void UnregisterDebug(bool destroyPanel) { }

	internal void UnregisterPerSceneData(ProbeVolumePerSceneData data) { }

	private void UpdateBlendingCellStreaming(CommandBuffer cmd) { }

	private void UpdateCellIndex(CellInfo cellInfo) { }

	public void UpdateCellStreaming(CommandBuffer cmd, Camera camera) { }

	public void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters) { }

	private void UpdatePool(List<BrickChunkAlloc> chunkList, PerScenarioData data, NativeArray<Byte> validityNeighMaskData, int chunkIndex, int poolIndex) { }

	private void UpdatePoolValidity(List<BrickChunkAlloc> chunkList, PerScenarioData data, NativeArray<Byte> validityNeighMaskData, int chunkIndex) { }

}

