namespace Fusion.XR.Host.SimpleHands;

public class OSFHandRepresentation : MonoBehaviour, IHandRepresentation
{
	public HandCommand currentCommand; //Field offset: 0x20
	public SkinnedMeshRenderer handMeshRenderer; //Field offset: 0x38
	public Animator handAnimator; //Field offset: 0x40
	[Header("Animation layers and configuration")]
	public string pinchAnimationParameter; //Field offset: 0x48
	public string flexAnimationParameter; //Field offset: 0x50
	public string poseAnimationParameter; //Field offset: 0x58
	public string pointAnimationLayer; //Field offset: 0x60
	public string thumbAnimationLayer; //Field offset: 0x68
	public float maxGripToPinch; //Field offset: 0x70
	private int pointAnimationLayerIndex; //Field offset: 0x74
	private int thumbAnimationLayerIndex; //Field offset: 0x78
	private bool layerIndexFound; //Field offset: 0x7C
	[CompilerGenerated]
	private bool <isVisible>k__BackingField; //Field offset: 0x7D

	public override bool IsMeshDisplayed
	{
		 get { } //Length: 28
	}

	public bool isVisible
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public override Material SharedHandMaterial
	{
		 get { } //Length: 136
	}

	public OSFHandRepresentation() { }

	public override HandCommand AnalyseCommand(HandCommand command) { }

	public override void ApplyCommand(HandCommand command) { }

	private void Awake() { }

	public override void DisplayMesh(bool shouldDisplay) { }

	private override GameObject Fusion.XR.Host.Rig.IHandRepresentation.get_gameObject() { }

	public override bool get_IsMeshDisplayed() { }

	[CompilerGenerated]
	public bool get_isVisible() { }

	public override Material get_SharedHandMaterial() { }

	private void OnBecameInvisible() { }

	private void OnBecameVisible() { }

	[CompilerGenerated]
	public void set_isVisible(bool value) { }

	public override void SetHandColor(Color color) { }

	public override void SetHandCommand(HandCommand command) { }

	public override void SetHandMaterial(Material material) { }

	private void Update() { }

}

