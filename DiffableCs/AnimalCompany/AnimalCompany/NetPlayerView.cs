namespace AnimalCompany;

public class NetPlayerView : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer[] _bodyRenderers; //Field offset: 0x20
	[SerializeField]
	private Transform _headTransform; //Field offset: 0x28
	[SerializeField]
	private Transform _rightHandTransform; //Field offset: 0x30
	[SerializeField]
	private Transform _leftHandTransform; //Field offset: 0x38
	[SerializeField]
	private Transform _bodyTransform; //Field offset: 0x40
	[SerializeField]
	private Transform _rightArmTransform; //Field offset: 0x48
	[SerializeField]
	private Transform _leftArmTransform; //Field offset: 0x50
	[SerializeField]
	private Transform _rightShoulderTransform; //Field offset: 0x58
	[SerializeField]
	private Transform _leftShoulderTransform; //Field offset: 0x60
	private Color _color; //Field offset: 0x68
	private Dictionary<Material, Material> _instancedMaterials; //Field offset: 0x78

	public NetPlayerView() { }

	public void SetColor(Color color) { }

	public void Setup() { }

	public void UpdateBodyView() { }

}

