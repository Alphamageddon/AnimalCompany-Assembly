namespace AnimalCompany;

[ExecuteInEditMode]
public class TestStretchyItem : MonoBehaviour
{
	[SerializeField]
	private Transform _stretchTransform; //Field offset: 0x20
	private readonly int _stretchMtxAttr; //Field offset: 0x28
	[SerializeField]
	private MeshRenderer _renderer; //Field offset: 0x30

	public TestStretchyItem() { }

	private void Update() { }

}

