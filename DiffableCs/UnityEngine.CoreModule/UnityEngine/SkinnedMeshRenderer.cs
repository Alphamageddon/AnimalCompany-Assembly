namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
[RequiredByNativeCode]
public class SkinnedMeshRenderer : Renderer
{

	public Transform[] bones
	{
		 set { } //Length: 68
	}

	public Transform rootBone
	{
		 set { } //Length: 68
	}

	[NativeProperty("Mesh")]
	public Mesh sharedMesh
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public Mesh get_sharedMesh() { }

	public float GetBlendShapeWeight(int index) { }

	public void set_bones(Transform[] value) { }

	public void set_rootBone(Transform value) { }

	public void set_sharedMesh(Mesh value) { }

	public void SetBlendShapeWeight(int index, float value) { }

}

