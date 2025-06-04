namespace UnityEngine.Animations.Rigging;

public struct ReadOnlyTransformHandle
{
	private TransformStreamHandle m_StreamHandle; //Field offset: 0x0
	private TransformSceneHandle m_SceneHandle; //Field offset: 0xC
	private byte m_InStream; //Field offset: 0x14

	public static ReadOnlyTransformHandle Bind(Animator animator, Transform transform) { }

	public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation) { }

	public Vector3 GetLocalPosition(AnimationStream stream) { }

	public Quaternion GetLocalRotation(AnimationStream stream) { }

	public Vector3 GetLocalScale(AnimationStream stream) { }

	public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) { }

	public Vector3 GetPosition(AnimationStream stream) { }

	public Quaternion GetRotation(AnimationStream stream) { }

	public bool IsResolved(AnimationStream stream) { }

	public bool IsValid(AnimationStream stream) { }

	public void Resolve(AnimationStream stream) { }

}

