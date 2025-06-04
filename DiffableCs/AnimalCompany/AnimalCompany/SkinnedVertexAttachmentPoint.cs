namespace AnimalCompany;

public class SkinnedVertexAttachmentPoint : MonoBehaviour
{
	[SerializeField]
	private AvatarRawBodyPartType _bodyPartType; //Field offset: 0x20
	[SerializeField]
	private AvatarView _avatarView; //Field offset: 0x28
	[SerializeField]
	private AvatarBodyBones[] _avatarBones; //Field offset: 0x30
	[SerializeField]
	private Matrix4x4[] _bindposes; //Field offset: 0x38
	[SerializeField]
	private BoneWeight _boneWeight; //Field offset: 0x40
	[SerializeField]
	private Vector3 _baseVertexPosition; //Field offset: 0x60
	[SerializeField]
	private int _cageVertexIndex; //Field offset: 0x6C
	[SerializeField]
	private Vector3 _positionOffset; //Field offset: 0x70
	private Transform _mainBone; //Field offset: 0x80
	private Quaternion _mainBoneRotationOffset; //Field offset: 0x88
	private Vector3[] _posBuf; //Field offset: 0x98

	public SkinnedVertexAttachmentPoint() { }

	private void Awake() { }

	private void CalcPositionWithBone(int boneIndex, ref Vector3 pos) { }

	private void HandleCageMeshUpdated(AvatarRawBodyPartType partType) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

}

