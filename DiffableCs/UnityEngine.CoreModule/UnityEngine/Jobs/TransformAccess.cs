namespace UnityEngine.Jobs;

[NativeHeader("Runtime/Transform/ScriptBindings/TransformAccess.bindings.h")]
public struct TransformAccess
{
	private IntPtr hierarchy; //Field offset: 0x0
	private int index; //Field offset: 0x8

	public Vector3 localScale
	{
		 get { } //Length: 92
	}

	public Matrix4x4 localToWorldMatrix
	{
		 get { } //Length: 108
	}

	public Vector3 position
	{
		 get { } //Length: 92
	}

	public Quaternion rotation
	{
		 get { } //Length: 88
	}

	public Vector3 get_localScale() { }

	public Matrix4x4 get_localToWorldMatrix() { }

	public Vector3 get_position() { }

	public Quaternion get_rotation() { }

	[NativeMethod(Name = "TransformAccessBindings::GetLocalScale", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetLocalScale(ref TransformAccess access, out Vector3 r) { }

	[NativeMethod(Name = "TransformAccessBindings::GetLocalToWorldMatrix", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetLocalToWorldMatrix(ref TransformAccess access, out Matrix4x4 m) { }

	[NativeMethod(Name = "TransformAccessBindings::GetPosition", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethod(Name = "TransformAccessBindings::GetRotation", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

}

