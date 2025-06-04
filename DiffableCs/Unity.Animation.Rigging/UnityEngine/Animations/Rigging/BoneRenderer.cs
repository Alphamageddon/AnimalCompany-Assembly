namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Setup/Bone Renderer")]
[ExecuteInEditMode]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/RiggingWorkflow.html#bone-renderer-component")]
public class BoneRenderer : MonoBehaviour
{
	internal enum BoneShape
	{
		Line = 0,
		Pyramid = 1,
		Box = 2,
	}

	public BoneShape boneShape; //Field offset: 0x20
	public bool drawBones; //Field offset: 0x24
	public bool drawTripods; //Field offset: 0x25
	[Range(0.01, 5)]
	public float boneSize; //Field offset: 0x28
	[Range(0.01, 5)]
	public float tripodSize; //Field offset: 0x2C
	public Color boneColor; //Field offset: 0x30
	[SerializeField]
	private Transform[] m_Transforms; //Field offset: 0x40

	public Transform[] transforms
	{
		 get { } //Length: 8
	}

	public BoneRenderer() { }

	public Transform[] get_transforms() { }

}

