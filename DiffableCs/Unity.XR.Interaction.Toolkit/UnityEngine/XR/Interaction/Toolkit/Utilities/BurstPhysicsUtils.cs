namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

[BurstCompile]
public static class BurstPhysicsUtils
{
	public static class GetConecastOffset_00000939$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static GetConecastOffset_00000939$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 origin, in float3 conePoint, in float3 direction, out float coneOffset) { }

	}

	internal sealed class GetConecastOffset_00000939$PostfixBurstDelegate : MulticastDelegate
	{

		public GetConecastOffset_00000939$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 origin, in float3 conePoint, in float3 direction, out float coneOffset, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 origin, in float3 conePoint, in float3 direction, out float coneOffset) { }

	}

	public static class GetConecastParameters_00000938$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static GetConecastParameters_00000938$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float angleRadius, float offset, float maxOffset, in Vector3 direction, out Vector3 originOffset, out float radius, out float castMax) { }

	}

	internal sealed class GetConecastParameters_00000938$PostfixBurstDelegate : MulticastDelegate
	{

		public GetConecastParameters_00000938$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float angleRadius, float offset, float maxOffset, in Vector3 direction, out Vector3 originOffset, out float radius, out float castMax, AsyncCallback unnamed_param_7, object unnamed_param_8) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float angleRadius, float offset, float maxOffset, in Vector3 direction, out Vector3 originOffset, out float radius, out float castMax) { }

	}

	public static class GetSphereOverlapParameters_00000937$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static GetSphereOverlapParameters_00000937$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in Vector3 overlapStart, in Vector3 overlapEnd, out Vector3 normalizedOverlapVector, out float overlapSqrMagnitude, out float overlapDistance) { }

	}

	internal sealed class GetSphereOverlapParameters_00000937$PostfixBurstDelegate : MulticastDelegate
	{

		public GetSphereOverlapParameters_00000937$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 overlapStart, in Vector3 overlapEnd, out Vector3 normalizedOverlapVector, out float overlapSqrMagnitude, out float overlapDistance, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in Vector3 overlapStart, in Vector3 overlapEnd, out Vector3 normalizedOverlapVector, out float overlapSqrMagnitude, out float overlapDistance) { }

	}


	[BurstCompile]
	public static void GetConecastOffset(in float3 origin, in float3 conePoint, in float3 direction, out float coneOffset) { }

	[BurstCompile]
	public static void GetConecastOffset$BurstManaged(in float3 origin, in float3 conePoint, in float3 direction, out float coneOffset) { }

	[BurstCompile]
	public static void GetConecastParameters(float angleRadius, float offset, float maxOffset, in Vector3 direction, out Vector3 originOffset, out float radius, out float castMax) { }

	[BurstCompile]
	public static void GetConecastParameters$BurstManaged(float angleRadius, float offset, float maxOffset, in Vector3 direction, out Vector3 originOffset, out float radius, out float castMax) { }

	[BurstCompile]
	public static void GetSphereOverlapParameters(in Vector3 overlapStart, in Vector3 overlapEnd, out Vector3 normalizedOverlapVector, out float overlapSqrMagnitude, out float overlapDistance) { }

	[BurstCompile]
	public static void GetSphereOverlapParameters$BurstManaged(in Vector3 overlapStart, in Vector3 overlapEnd, out Vector3 normalizedOverlapVector, out float overlapSqrMagnitude, out float overlapDistance) { }

}

