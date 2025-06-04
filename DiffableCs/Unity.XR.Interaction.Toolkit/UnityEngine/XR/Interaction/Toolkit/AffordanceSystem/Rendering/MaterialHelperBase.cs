namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Rendering;

public abstract class MaterialHelperBase : MonoBehaviour
{
	[SerializeField]
	private Renderer m_Renderer; //Field offset: 0x20
	[SerializeField]
	private int m_MaterialIndex; //Field offset: 0x28
	[CompilerGenerated]
	private bool <isInitialized>k__BackingField; //Field offset: 0x2C

	protected private bool isInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public int materialIndex
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Renderer rendererTarget
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected MaterialHelperBase() { }

	[CompilerGenerated]
	protected bool get_isInitialized() { }

	public int get_materialIndex() { }

	public Renderer get_rendererTarget() { }

	public Material GetSharedMaterialForTarget() { }

	protected override void Initialize() { }

	protected void OnEnable() { }

	[CompilerGenerated]
	private void set_isInitialized(bool value) { }

	public void set_materialIndex(int value) { }

	public void set_rendererTarget(Renderer value) { }

}

