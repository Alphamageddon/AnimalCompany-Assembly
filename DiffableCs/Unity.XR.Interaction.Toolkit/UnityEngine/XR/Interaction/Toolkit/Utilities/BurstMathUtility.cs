namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

[BurstCompile]
public static class BurstMathUtility
{
	public static class Angle_0000092E$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Angle_0000092E$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in quaternion a, in quaternion b, out float angle) { }

	}

	internal sealed class Angle_0000092E$PostfixBurstDelegate : MulticastDelegate
	{

		public Angle_0000092E$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in quaternion a, in quaternion b, out float angle, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in quaternion a, in quaternion b, out float angle) { }

	}

	public static class FastSafeDivide_00000931$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static FastSafeDivide_00000931$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in Vector3 a, in Vector3 b, out Vector3 result, float tolerance = 1E-06) { }

	}

	internal sealed class FastSafeDivide_00000931$PostfixBurstDelegate : MulticastDelegate
	{

		public FastSafeDivide_00000931$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 a, in Vector3 b, out Vector3 result, float tolerance = 1E-06, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in Vector3 a, in Vector3 b, out Vector3 result, float tolerance = 1E-06) { }

	}

	public static class FastSafeDivide_00000932$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static FastSafeDivide_00000932$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 a, in float3 b, out float3 result, float tolerance = 1E-06) { }

	}

	internal sealed class FastSafeDivide_00000932$PostfixBurstDelegate : MulticastDelegate
	{

		public FastSafeDivide_00000932$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 a, in float3 b, out float3 result, float tolerance = 1E-06, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 a, in float3 b, out float3 result, float tolerance = 1E-06) { }

	}

	public static class FastVectorEquals_0000092F$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static FastVectorEquals_0000092F$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static bool Invoke(in float3 a, in float3 b, float tolerance = 0.0001) { }

	}

	internal sealed class FastVectorEquals_0000092F$PostfixBurstDelegate : MulticastDelegate
	{

		public FastVectorEquals_0000092F$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 a, in float3 b, float tolerance = 0.0001, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override bool EndInvoke(IAsyncResult unnamed_param_0) { }

		public override bool Invoke(in float3 a, in float3 b, float tolerance = 0.0001) { }

	}

	public static class FastVectorEquals_00000930$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static FastVectorEquals_00000930$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static bool Invoke(in Vector3 a, in Vector3 b, float tolerance = 0.0001) { }

	}

	internal sealed class FastVectorEquals_00000930$PostfixBurstDelegate : MulticastDelegate
	{

		public FastVectorEquals_00000930$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 a, in Vector3 b, float tolerance = 0.0001, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override bool EndInvoke(IAsyncResult unnamed_param_0) { }

		public override bool Invoke(in Vector3 a, in Vector3 b, float tolerance = 0.0001) { }

	}

	public static class LookRotationWithForwardProjectedOnPlane_0000092C$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static LookRotationWithForwardProjectedOnPlane_0000092C$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 forward, in float3 planeNormal, out quaternion lookRotation) { }

	}

	internal sealed class LookRotationWithForwardProjectedOnPlane_0000092C$PostfixBurstDelegate : MulticastDelegate
	{

		public LookRotationWithForwardProjectedOnPlane_0000092C$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 forward, in float3 planeNormal, out quaternion lookRotation, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 forward, in float3 planeNormal, out quaternion lookRotation) { }

	}

	public static class LookRotationWithForwardProjectedOnPlane_0000092D$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static LookRotationWithForwardProjectedOnPlane_0000092D$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in Vector3 forward, in Vector3 planeNormal, out Quaternion lookRotation) { }

	}

	internal sealed class LookRotationWithForwardProjectedOnPlane_0000092D$PostfixBurstDelegate : MulticastDelegate
	{

		public LookRotationWithForwardProjectedOnPlane_0000092D$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 forward, in Vector3 planeNormal, out Quaternion lookRotation, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in Vector3 forward, in Vector3 planeNormal, out Quaternion lookRotation) { }

	}

	public static class Orthogonal_00000936$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Orthogonal_00000936$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 input, out float3 result) { }

	}

	internal sealed class Orthogonal_00000936$PostfixBurstDelegate : MulticastDelegate
	{

		public Orthogonal_00000936$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 input, out float3 result, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 input, out float3 result) { }

	}

	public static class OrthogonalLookRotation_00000928$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static OrthogonalLookRotation_00000928$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in Vector3 forward, in Vector3 referenceUp, out Quaternion lookRotation) { }

	}

	internal sealed class OrthogonalLookRotation_00000928$PostfixBurstDelegate : MulticastDelegate
	{

		public OrthogonalLookRotation_00000928$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 forward, in Vector3 referenceUp, out Quaternion lookRotation, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in Vector3 forward, in Vector3 referenceUp, out Quaternion lookRotation) { }

	}

	public static class OrthogonalLookRotation_00000929$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static OrthogonalLookRotation_00000929$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 forward, in float3 referenceUp, out quaternion lookRotation) { }

	}

	internal sealed class OrthogonalLookRotation_00000929$PostfixBurstDelegate : MulticastDelegate
	{

		public OrthogonalLookRotation_00000929$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 forward, in float3 referenceUp, out quaternion lookRotation, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 forward, in float3 referenceUp, out quaternion lookRotation) { }

	}

	public static class OrthogonalUpVector_00000926$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static OrthogonalUpVector_00000926$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in Vector3 forward, in Vector3 referenceUp, out Vector3 orthogonalUp) { }

	}

	internal sealed class OrthogonalUpVector_00000926$PostfixBurstDelegate : MulticastDelegate
	{

		public OrthogonalUpVector_00000926$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 forward, in Vector3 referenceUp, out Vector3 orthogonalUp, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in Vector3 forward, in Vector3 referenceUp, out Vector3 orthogonalUp) { }

	}

	public static class OrthogonalUpVector_00000927$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static OrthogonalUpVector_00000927$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 forward, in float3 referenceUp, out float3 orthogonalUp) { }

	}

	internal sealed class OrthogonalUpVector_00000927$PostfixBurstDelegate : MulticastDelegate
	{

		public OrthogonalUpVector_00000927$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 forward, in float3 referenceUp, out float3 orthogonalUp, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 forward, in float3 referenceUp, out float3 orthogonalUp) { }

	}

	public static class ProjectOnPlane_0000092A$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static ProjectOnPlane_0000092A$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 vector, in float3 planeNormal, out float3 projectedVector) { }

	}

	internal sealed class ProjectOnPlane_0000092A$PostfixBurstDelegate : MulticastDelegate
	{

		public ProjectOnPlane_0000092A$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 vector, in float3 planeNormal, out float3 projectedVector, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 vector, in float3 planeNormal, out float3 projectedVector) { }

	}

	public static class ProjectOnPlane_0000092B$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static ProjectOnPlane_0000092B$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in Vector3 vector, in Vector3 planeNormal, out Vector3 projectedVector) { }

	}

	internal sealed class ProjectOnPlane_0000092B$PostfixBurstDelegate : MulticastDelegate
	{

		public ProjectOnPlane_0000092B$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 vector, in Vector3 planeNormal, out Vector3 projectedVector, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in Vector3 vector, in Vector3 planeNormal, out Vector3 projectedVector) { }

	}

	public static class Scale_00000933$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Scale_00000933$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 a, in float3 b, out float3 result) { }

	}

	internal sealed class Scale_00000933$PostfixBurstDelegate : MulticastDelegate
	{

		public Scale_00000933$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 a, in float3 b, out float3 result, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 a, in float3 b, out float3 result) { }

	}

	public static class Scale_00000934$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Scale_00000934$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in Vector3 a, in Vector3 b, out Vector3 result) { }

	}

	internal sealed class Scale_00000934$PostfixBurstDelegate : MulticastDelegate
	{

		public Scale_00000934$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in Vector3 a, in Vector3 b, out Vector3 result, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in Vector3 a, in Vector3 b, out Vector3 result) { }

	}


	[BurstCompile]
	public static void Angle(in quaternion a, in quaternion b, out float angle) { }

	[BurstCompile]
	public static void Angle$BurstManaged(in quaternion a, in quaternion b, out float angle) { }

	[BurstCompile]
	public static void FastSafeDivide(in Vector3 a, in Vector3 b, out Vector3 result, float tolerance = 1E-06) { }

	[BurstCompile]
	public static void FastSafeDivide(in float3 a, in float3 b, out float3 result, float tolerance = 1E-06) { }

	[BurstCompile]
	public static void FastSafeDivide$BurstManaged(in float3 a, in float3 b, out float3 result, float tolerance = 1E-06) { }

	[BurstCompile]
	public static void FastSafeDivide$BurstManaged(in Vector3 a, in Vector3 b, out Vector3 result, float tolerance = 1E-06) { }

	[BurstCompile]
	public static bool FastVectorEquals(in float3 a, in float3 b, float tolerance = 0.0001) { }

	[BurstCompile]
	public static bool FastVectorEquals(in Vector3 a, in Vector3 b, float tolerance = 0.0001) { }

	[BurstCompile]
	public static bool FastVectorEquals$BurstManaged(in Vector3 a, in Vector3 b, float tolerance = 0.0001) { }

	[BurstCompile]
	public static bool FastVectorEquals$BurstManaged(in float3 a, in float3 b, float tolerance = 0.0001) { }

	[BurstCompile]
	public static void LookRotationWithForwardProjectedOnPlane(in float3 forward, in float3 planeNormal, out quaternion lookRotation) { }

	[BurstCompile]
	public static void LookRotationWithForwardProjectedOnPlane(in Vector3 forward, in Vector3 planeNormal, out Quaternion lookRotation) { }

	[BurstCompile]
	public static void LookRotationWithForwardProjectedOnPlane$BurstManaged(in Vector3 forward, in Vector3 planeNormal, out Quaternion lookRotation) { }

	[BurstCompile]
	public static void LookRotationWithForwardProjectedOnPlane$BurstManaged(in float3 forward, in float3 planeNormal, out quaternion lookRotation) { }

	[BurstCompile]
	internal static void Orthogonal(in float3 input, out float3 result) { }

	internal static Vector3 Orthogonal(Vector3 input) { }

	[BurstCompile]
	public static void Orthogonal$BurstManaged(in float3 input, out float3 result) { }

	[BurstCompile]
	public static void OrthogonalLookRotation(in float3 forward, in float3 referenceUp, out quaternion lookRotation) { }

	[BurstCompile]
	public static void OrthogonalLookRotation(in Vector3 forward, in Vector3 referenceUp, out Quaternion lookRotation) { }

	[BurstCompile]
	public static void OrthogonalLookRotation$BurstManaged(in Vector3 forward, in Vector3 referenceUp, out Quaternion lookRotation) { }

	[BurstCompile]
	public static void OrthogonalLookRotation$BurstManaged(in float3 forward, in float3 referenceUp, out quaternion lookRotation) { }

	[BurstCompile]
	public static void OrthogonalUpVector(in float3 forward, in float3 referenceUp, out float3 orthogonalUp) { }

	[BurstCompile]
	public static void OrthogonalUpVector(in Vector3 forward, in Vector3 referenceUp, out Vector3 orthogonalUp) { }

	[BurstCompile]
	public static void OrthogonalUpVector$BurstManaged(in Vector3 forward, in Vector3 referenceUp, out Vector3 orthogonalUp) { }

	[BurstCompile]
	public static void OrthogonalUpVector$BurstManaged(in float3 forward, in float3 referenceUp, out float3 orthogonalUp) { }

	[BurstCompile]
	public static void ProjectOnPlane(in Vector3 vector, in Vector3 planeNormal, out Vector3 projectedVector) { }

	[BurstCompile]
	public static void ProjectOnPlane(in float3 vector, in float3 planeNormal, out float3 projectedVector) { }

	[BurstCompile]
	public static void ProjectOnPlane$BurstManaged(in float3 vector, in float3 planeNormal, out float3 projectedVector) { }

	[BurstCompile]
	public static void ProjectOnPlane$BurstManaged(in Vector3 vector, in Vector3 planeNormal, out Vector3 projectedVector) { }

	[BurstCompile]
	public static void Scale(in Vector3 a, in Vector3 b, out Vector3 result) { }

	[BurstCompile]
	public static void Scale(in float3 a, in float3 b, out float3 result) { }

	[BurstCompile]
	public static void Scale$BurstManaged(in float3 a, in float3 b, out float3 result) { }

	[BurstCompile]
	public static void Scale$BurstManaged(in Vector3 a, in Vector3 b, out Vector3 result) { }

}

