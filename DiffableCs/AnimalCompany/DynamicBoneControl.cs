//Type is in global namespace

public class DynamicBoneControl : MonoBehaviour
{
	internal class BoneGroup
	{
		public string name; //Field offset: 0x10
		public Transform[] bones; //Field offset: 0x18
		public Node[] nodes; //Field offset: 0x20
		public Vector3 rotationAxis; //Field offset: 0x28
		public Vector3 rotationOffset; //Field offset: 0x34
		[Header("Settings")]
		public float damping; //Field offset: 0x40
		[Range(0, 1)]
		public float drag; //Field offset: 0x44
		[Range(0, 1)]
		public float stiffness; //Field offset: 0x48

		public BoneGroup() { }

	}

	internal class Node
	{
		public Transform parent; //Field offset: 0x10
		public Vector3 pos; //Field offset: 0x18
		public Vector3 initialLocalPosition; //Field offset: 0x24
		public Quaternion initialLocalRotation; //Field offset: 0x30
		public Vector3 vel; //Field offset: 0x40
		public float lengthToParent; //Field offset: 0x4C

		public Node(Transform parent, Vector3 pos, Vector3 initialLocalPosition, Quaternion initialLocalRotation) { }

		public void Update(Vector3 targetPos, float deltaTime, float damping, float drag, float stiffness) { }

	}

	public bool isUpdate; //Field offset: 0x20
	[SerializeField]
	private Transform root; //Field offset: 0x28
	[SerializeField]
	private BoneGroup[] boneGroups; //Field offset: 0x30

	public DynamicBoneControl() { }

	private void LateUpdate() { }

	private void OnEnable() { }

}

