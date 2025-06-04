namespace UnityEngine.Animations.Rigging;

internal class SyncSceneToStreamLayer
{
	[CompilerGenerated]
	private bool <isInitialized>k__BackingField; //Field offset: 0x10
	public IAnimationJob job; //Field offset: 0x18
	private IAnimationJobData m_Data; //Field offset: 0x20
	private List<Int32> m_RigIndices; //Field offset: 0x28

	public private bool isInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public SyncSceneToStreamLayer() { }

	[CompilerGenerated]
	public bool get_isInitialized() { }

	public bool Initialize(Animator animator, IList<IRigLayer> layers) { }

	public bool IsValid() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_isInitialized(bool value) { }

	public void Update(IList<IRigLayer> layers) { }

}

