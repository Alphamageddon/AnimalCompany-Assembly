namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Curves;

[BurstCompile]
internal static class CurveUtility
{
	public static class CalculateProjectileFlightTime_000009F8$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static CalculateProjectileFlightTime_000009F8$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float velocityMagnitude, float gravityAcceleration, float angleRad, float height, float extraFlightTime, out float flightTime) { }

	}

	internal sealed class CalculateProjectileFlightTime_000009F8$PostfixBurstDelegate : MulticastDelegate
	{

		public CalculateProjectileFlightTime_000009F8$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float velocityMagnitude, float gravityAcceleration, float angleRad, float height, float extraFlightTime, out float flightTime, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float velocityMagnitude, float gravityAcceleration, float angleRad, float height, float extraFlightTime, out float flightTime) { }

	}

	public static class ElevateQuadraticToCubicBezier_000009F5$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static ElevateQuadraticToCubicBezier_000009F5$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 p0, in float3 p1, in float3 p2, out float3 c0, out float3 c1, out float3 c2, out float3 c3) { }

	}

	internal sealed class ElevateQuadraticToCubicBezier_000009F5$PostfixBurstDelegate : MulticastDelegate
	{

		public ElevateQuadraticToCubicBezier_000009F5$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 p0, in float3 p1, in float3 p2, out float3 c0, out float3 c1, out float3 c2, out float3 c3, AsyncCallback unnamed_param_7, object unnamed_param_8) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 p0, in float3 p1, in float3 p2, out float3 c0, out float3 c1, out float3 c2, out float3 c3) { }

	}

	public static class GenerateCubicBezierCurve_000009F6$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static GenerateCubicBezierCurve_000009F6$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(int numTargetPoints, float curveRatio, in float3 lineOrigin, in float3 lineDirection, in float3 endPoint, ref NativeArray<float3>& targetPoints) { }

	}

	internal sealed class GenerateCubicBezierCurve_000009F6$PostfixBurstDelegate : MulticastDelegate
	{

		public GenerateCubicBezierCurve_000009F6$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(int numTargetPoints, float curveRatio, in float3 lineOrigin, in float3 lineDirection, in float3 endPoint, ref NativeArray<float3>& targetPoints, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(int numTargetPoints, float curveRatio, in float3 lineOrigin, in float3 lineDirection, in float3 endPoint, ref NativeArray<float3>& targetPoints) { }

	}

	public static class SampleCubicBezierPoint_000009F4$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static SampleCubicBezierPoint_000009F4$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 point) { }

	}

	internal sealed class SampleCubicBezierPoint_000009F4$PostfixBurstDelegate : MulticastDelegate
	{

		public SampleCubicBezierPoint_000009F4$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 point, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 point) { }

	}

	public static class SampleProjectilePoint_000009F7$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static SampleProjectilePoint_000009F7$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 initialPosition, in float3 initialVelocity, in float3 constantAcceleration, float time, out float3 point) { }

	}

	internal sealed class SampleProjectilePoint_000009F7$PostfixBurstDelegate : MulticastDelegate
	{

		public SampleProjectilePoint_000009F7$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 initialPosition, in float3 initialVelocity, in float3 constantAcceleration, float time, out float3 point, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 initialPosition, in float3 initialVelocity, in float3 constantAcceleration, float time, out float3 point) { }

	}

	public static class SampleQuadraticBezierPoint_000009F3$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static SampleQuadraticBezierPoint_000009F3$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 p0, in float3 p1, in float3 p2, float t, out float3 point) { }

	}

	internal sealed class SampleQuadraticBezierPoint_000009F3$PostfixBurstDelegate : MulticastDelegate
	{

		public SampleQuadraticBezierPoint_000009F3$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 p0, in float3 p1, in float3 p2, float t, out float3 point, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 p0, in float3 p1, in float3 p2, float t, out float3 point) { }

	}

	private const float k_EightEpsilon = 9.536743E-07; //Field offset: 0x0

	[BurstCompile]
	public static void CalculateProjectileFlightTime(float velocityMagnitude, float gravityAcceleration, float angleRad, float height, float extraFlightTime, out float flightTime) { }

	[BurstCompile]
	public static void CalculateProjectileFlightTime$BurstManaged(float velocityMagnitude, float gravityAcceleration, float angleRad, float height, float extraFlightTime, out float flightTime) { }

	[BurstCompile]
	public static void ElevateQuadraticToCubicBezier(in float3 p0, in float3 p1, in float3 p2, out float3 c0, out float3 c1, out float3 c2, out float3 c3) { }

	[BurstCompile]
	public static void ElevateQuadraticToCubicBezier$BurstManaged(in float3 p0, in float3 p1, in float3 p2, out float3 c0, out float3 c1, out float3 c2, out float3 c3) { }

	[BurstCompile]
	public static void GenerateCubicBezierCurve(int numTargetPoints, float curveRatio, in float3 lineOrigin, in float3 lineDirection, in float3 endPoint, ref NativeArray<float3>& targetPoints) { }

	[BurstCompile]
	public static void GenerateCubicBezierCurve$BurstManaged(int numTargetPoints, float curveRatio, in float3 lineOrigin, in float3 lineDirection, in float3 endPoint, ref NativeArray<float3>& targetPoints) { }

	[BurstCompile]
	public static void SampleCubicBezierPoint(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 point) { }

	[BurstCompile]
	public static void SampleCubicBezierPoint$BurstManaged(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 point) { }

	[BurstCompile]
	public static void SampleProjectilePoint(in float3 initialPosition, in float3 initialVelocity, in float3 constantAcceleration, float time, out float3 point) { }

	[BurstCompile]
	public static void SampleProjectilePoint$BurstManaged(in float3 initialPosition, in float3 initialVelocity, in float3 constantAcceleration, float time, out float3 point) { }

	[BurstCompile]
	public static void SampleQuadraticBezierPoint(in float3 p0, in float3 p1, in float3 p2, float t, out float3 point) { }

	[BurstCompile]
	public static void SampleQuadraticBezierPoint$BurstManaged(in float3 p0, in float3 p1, in float3 p2, float t, out float3 point) { }

}

