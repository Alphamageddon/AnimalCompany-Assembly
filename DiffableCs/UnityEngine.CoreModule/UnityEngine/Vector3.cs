namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector3f")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeHeader("Runtime/Math/Vector3.h")]
[NativeType(Header = "Runtime/Math/Vector3.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Vector3 : IEquatable<Vector3>, IFormattable
{
	public const float kEpsilon = 1E-05; //Field offset: 0x0
	public const float kEpsilonNormalSqrt = 1E-15; //Field offset: 0x0
	private static readonly Vector3 zeroVector; //Field offset: 0x0
	private static readonly Vector3 oneVector; //Field offset: 0xC
	private static readonly Vector3 upVector; //Field offset: 0x18
	private static readonly Vector3 downVector; //Field offset: 0x24
	private static readonly Vector3 leftVector; //Field offset: 0x30
	private static readonly Vector3 rightVector; //Field offset: 0x3C
	private static readonly Vector3 forwardVector; //Field offset: 0x48
	private static readonly Vector3 backVector; //Field offset: 0x54
	private static readonly Vector3 positiveInfinityVector; //Field offset: 0x60
	private static readonly Vector3 negativeInfinityVector; //Field offset: 0x6C
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4
	public float z; //Field offset: 0x8

	public static Vector3 back
	{
		 get { } //Length: 76
	}

	public static Vector3 down
	{
		 get { } //Length: 76
	}

	public static Vector3 forward
	{
		 get { } //Length: 76
	}

	public float Item
	{
		 get { } //Length: 120
		 set { } //Length: 120
	}

	public static Vector3 left
	{
		 get { } //Length: 76
	}

	public float magnitude
	{
		 get { } //Length: 128
	}

	public Vector3 normalized
	{
		 get { } //Length: 204
	}

	public static Vector3 one
	{
		 get { } //Length: 76
	}

	public static Vector3 positiveInfinity
	{
		 get { } //Length: 76
	}

	public static Vector3 right
	{
		 get { } //Length: 76
	}

	public float sqrMagnitude
	{
		 get { } //Length: 32
	}

	public static Vector3 up
	{
		 get { } //Length: 76
	}

	public static Vector3 zero
	{
		 get { } //Length: 76
	}

	private static Vector3() { }

	public Vector3(float x, float y) { }

	public Vector3(float x, float y, float z) { }

	public static float Angle(Vector3 from, Vector3 to) { }

	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	public static float Distance(Vector3 a, Vector3 b) { }

	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(Vector3 other) { }

	public static Vector3 get_back() { }

	public static Vector3 get_down() { }

	public static Vector3 get_forward() { }

	public float get_Item(int index) { }

	public static Vector3 get_left() { }

	public float get_magnitude() { }

	public Vector3 get_normalized() { }

	public static Vector3 get_one() { }

	public static Vector3 get_positiveInfinity() { }

	public static Vector3 get_right() { }

	public float get_sqrMagnitude() { }

	public static Vector3 get_up() { }

	public static Vector3 get_zero() { }

	public virtual int GetHashCode() { }

	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	public static float Magnitude(Vector3 vector) { }

	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	public static Vector3 Normalize(Vector3 value) { }

	public void Normalize() { }

	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	public static Vector3 op_Division(Vector3 a, float d) { }

	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	public static Vector3 op_Multiply(float d, Vector3 a) { }

	public static Vector3 op_Multiply(Vector3 a, float d) { }

	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	public static Vector3 op_UnaryNegation(Vector3 a) { }

	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	[FreeFunction("VectorScripting::OrthoNormalize", IsThreadSafe = True)]
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	public void Scale(Vector3 scale) { }

	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	public void set_Item(int index, float value) { }

	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	[FreeFunction("VectorScripting::Slerp", IsThreadSafe = True)]
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	[ExcludeFromDocs]
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

	public static float SqrMagnitude(Vector3 vector) { }

	public virtual string ToString() { }

	public string ToString(string format) { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

