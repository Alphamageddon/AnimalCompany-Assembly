namespace UnityEngine.Animations.Rigging;

public struct ReadWriteTransformHandle
{
	private TransformStreamHandle m_Handle; //Field offset: 0x0

	public static ReadWriteTransformHandle Bind(Animator animator, Transform transform) { }

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

	public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask = false) { }

	public void SetLocalPosition(AnimationStream stream, Vector3 position) { }

	public void SetLocalRotation(AnimationStream stream, Quaternion rotation) { }

	public void SetLocalScale(AnimationStream stream, Vector3 scale) { }

	public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask = false) { }

	public void SetPosition(AnimationStream stream, Vector3 position) { }

	public void SetRotation(AnimationStream stream, Quaternion rotation) { }

}

