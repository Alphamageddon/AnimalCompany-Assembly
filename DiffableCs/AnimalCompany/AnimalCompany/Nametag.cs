namespace AnimalCompany;

public class Nametag : MonoBehaviour
{
	[SerializeField]
	private TextMeshPro _tmp; //Field offset: 0x20
	[SerializeField]
	private Transform _attachPoint; //Field offset: 0x28
	[SerializeField]
	private SkinnedMeshRenderer _skinnedMesh; //Field offset: 0x30
	[SerializeField]
	private BoneWeight _boneWeight; //Field offset: 0x38
	[SerializeField]
	private int _attachedVertexIndex; //Field offset: 0x58
	[SerializeField]
	private Vector3 _baseVertexPosition; //Field offset: 0x5C
	private Vector3[] _posBuf; //Field offset: 0x68

	public Nametag() { }

	private void CalcPositionWithBone(int boneIndex, ref Vector3 pos) { }

	private void LateUpdate() { }

	public void SetName(string name) { }

	[ContextMenu("Setup bone attachment")]
	private void SetupBoneAttachment() { }

}

