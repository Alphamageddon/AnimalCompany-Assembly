namespace Fusion;

public static class ReadWriteUtils
{
	public const float ACCURACY = 1024; //Field offset: 0x0

	public static float ReadFloat(Int32* data) { }

	public static NetworkBehaviour ReadNetworkBehaviourRef(Int32* data, NetworkRunner runner, out bool isValid) { }

	public static Quaternion ReadQuaternion(Int32* data) { }

	public static Vector2 ReadVector2(Int32* data) { }

	public static Vector3 ReadVector3(Int32* data) { }

	public static Vector4 ReadVector4(Int32* data) { }

	public static void WriteEmptyNetworkBehaviourRef(Int32* data) { }

	public static void WriteFloat(Int32* data, float f) { }

	public static void WriteNetworkBehaviourRef(Int32* data, NetworkRunner runner, NetworkBehaviour reference) { }

	public static void WriteNullBehaviourRef(Int32* data) { }

	public static void WriteQuaternion(Int32* data, Quaternion value) { }

	public static void WriteVector2(Int32* data, Vector2 value) { }

	public static void WriteVector3(Int32* data, Vector3 value) { }

	public static void WriteVector4(Int32* data, Vector4 value) { }

}

