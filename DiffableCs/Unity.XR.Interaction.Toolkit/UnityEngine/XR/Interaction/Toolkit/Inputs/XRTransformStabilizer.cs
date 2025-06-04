namespace UnityEngine.XR.Interaction.Toolkit.Inputs;

[AddComponentMenu("XR/XR Transform Stabilizer", 11)]
[BurstCompile]
[DefaultExecutionOrder(-29985)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.html")]
public class XRTransformStabilizer : MonoBehaviour
{
	public static class CalculateRotationParams_00000D41$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static CalculateRotationParams_00000D41$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 currentPosition, in float3 resultPosition, in float3 forward, in float3 up, in float3 rayEnd, float invScale, float angleStabilization, out quaternion antiRotation, out float scaleFactor, out float targetAngleScale) { }

	}

	internal sealed class CalculateRotationParams_00000D41$PostfixBurstDelegate : MulticastDelegate
	{

		public CalculateRotationParams_00000D41$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 currentPosition, in float3 resultPosition, in float3 forward, in float3 up, in float3 rayEnd, float invScale, float angleStabilization, out quaternion antiRotation, out float scaleFactor, out float targetAngleScale, AsyncCallback unnamed_param_10, object unnamed_param_11) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 currentPosition, in float3 resultPosition, in float3 forward, in float3 up, in float3 rayEnd, float invScale, float angleStabilization, out quaternion antiRotation, out float scaleFactor, out float targetAngleScale) { }

	}

	public static class CalculateStabilizedLerp_00000D40$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static CalculateStabilizedLerp_00000D40$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static float Invoke(float distance, float timeSlice) { }

	}

	internal sealed class CalculateStabilizedLerp_00000D40$PostfixBurstDelegate : MulticastDelegate
	{

		public CalculateStabilizedLerp_00000D40$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float distance, float timeSlice, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		public override float EndInvoke(IAsyncResult unnamed_param_0) { }

		public override float Invoke(float distance, float timeSlice) { }

	}

	public static class StabilizeOptimalRotation_00000D3F$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static StabilizeOptimalRotation_00000D3F$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in quaternion startRot, in quaternion targetRot, in quaternion alternateStartRot, float deltaTime, float angleStabilization, float alternateStabilization, float scaleFactor, out quaternion resultRot) { }

	}

	internal sealed class StabilizeOptimalRotation_00000D3F$PostfixBurstDelegate : MulticastDelegate
	{

		public StabilizeOptimalRotation_00000D3F$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in quaternion startRot, in quaternion targetRot, in quaternion alternateStartRot, float deltaTime, float angleStabilization, float alternateStabilization, float scaleFactor, out quaternion resultRot, AsyncCallback unnamed_param_8, object unnamed_param_9) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in quaternion startRot, in quaternion targetRot, in quaternion alternateStartRot, float deltaTime, float angleStabilization, float alternateStabilization, float scaleFactor, out quaternion resultRot) { }

	}

	public static class StabilizePosition_00000D3E$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static StabilizePosition_00000D3E$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 startPos, in float3 targetPos, float deltaTime, float positionStabilization, out float3 resultPos) { }

	}

	internal sealed class StabilizePosition_00000D3E$PostfixBurstDelegate : MulticastDelegate
	{

		public StabilizePosition_00000D3E$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 startPos, in float3 targetPos, float deltaTime, float positionStabilization, out float3 resultPos, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 startPos, in float3 targetPos, float deltaTime, float positionStabilization, out float3 resultPos) { }

	}

	public static class StabilizeTransform_00000D3D$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static StabilizeTransform_00000D3D$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 startPos, in quaternion startRot, in float3 targetPos, in quaternion targetRot, float deltaTime, float positionStabilization, float angleStabilization, out float3 resultPos, out quaternion resultRot) { }

	}

	internal sealed class StabilizeTransform_00000D3D$PostfixBurstDelegate : MulticastDelegate
	{

		public StabilizeTransform_00000D3D$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 startPos, in quaternion startRot, in float3 targetPos, in quaternion targetRot, float deltaTime, float positionStabilization, float angleStabilization, out float3 resultPos, out quaternion resultRot, AsyncCallback unnamed_param_9, object unnamed_param_10) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 startPos, in quaternion startRot, in float3 targetPos, in quaternion targetRot, float deltaTime, float positionStabilization, float angleStabilization, out float3 resultPos, out quaternion resultRot) { }

	}

	private const float k_90FPS = 0.011111111; //Field offset: 0x0
	[SerializeField]
	[Tooltip("The Transform component whose position and rotation will be matched and stabilized.")]
	private Transform m_Target; //Field offset: 0x20
	[RequireInterface(typeof(IXRRayProvider))]
	[SerializeField]
	[Tooltip("Optional - When provided a ray, the stabilizer will calculate the rotation that keeps a ray's endpoint stable.")]
	private object m_AimTargetObject; //Field offset: 0x28
	private IXRRayProvider m_AimTarget; //Field offset: 0x30
	[SerializeField]
	[Tooltip("If enabled, will read the target and apply stabilization in local space. Otherwise, in world space.")]
	private bool m_UseLocalSpace; //Field offset: 0x38
	[Header("Stabilization Parameters")]
	[SerializeField]
	[Tooltip("Maximum distance (in degrees) that stabilization will be applied.")]
	private float m_AngleStabilization; //Field offset: 0x3C
	[SerializeField]
	[Tooltip("Maximum distance (in meters) that stabilization will be applied.")]
	private float m_PositionStabilization; //Field offset: 0x40
	private Transform m_ThisTransform; //Field offset: 0x48

	public IXRRayProvider aimTarget
	{
		 get { } //Length: 8
		 set { } //Length: 140
	}

	public float angleStabilization
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float positionStabilization
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Transform targetTransform
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool useLocalSpace
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public XRTransformStabilizer() { }

	protected void Awake() { }

	[BurstCompile]
	private static void CalculateRotationParams(in float3 currentPosition, in float3 resultPosition, in float3 forward, in float3 up, in float3 rayEnd, float invScale, float angleStabilization, out quaternion antiRotation, out float scaleFactor, out float targetAngleScale) { }

	[BurstCompile]
	public static void CalculateRotationParams$BurstManaged(in float3 currentPosition, in float3 resultPosition, in float3 forward, in float3 up, in float3 rayEnd, float invScale, float angleStabilization, out quaternion antiRotation, out float scaleFactor, out float targetAngleScale) { }

	[BurstCompile]
	private static float CalculateStabilizedLerp(float distance, float timeSlice) { }

	[BurstCompile]
	public static float CalculateStabilizedLerp$BurstManaged(float distance, float timeSlice) { }

	public IXRRayProvider get_aimTarget() { }

	public float get_angleStabilization() { }

	public float get_positionStabilization() { }

	public Transform get_targetTransform() { }

	public bool get_useLocalSpace() { }

	protected void OnEnable() { }

	public void set_aimTarget(IXRRayProvider value) { }

	public void set_angleStabilization(float value) { }

	public void set_positionStabilization(float value) { }

	public void set_targetTransform(Transform value) { }

	public void set_useLocalSpace(bool value) { }

	[BurstCompile]
	private static void StabilizeOptimalRotation(in quaternion startRot, in quaternion targetRot, in quaternion alternateStartRot, float deltaTime, float angleStabilization, float alternateStabilization, float scaleFactor, out quaternion resultRot) { }

	[BurstCompile]
	public static void StabilizeOptimalRotation$BurstManaged(in quaternion startRot, in quaternion targetRot, in quaternion alternateStartRot, float deltaTime, float angleStabilization, float alternateStabilization, float scaleFactor, out quaternion resultRot) { }

	[BurstCompile]
	private static void StabilizePosition(in float3 startPos, in float3 targetPos, float deltaTime, float positionStabilization, out float3 resultPos) { }

	[BurstCompile]
	public static void StabilizePosition$BurstManaged(in float3 startPos, in float3 targetPos, float deltaTime, float positionStabilization, out float3 resultPos) { }

	[BurstCompile]
	private static void StabilizeTransform(in float3 startPos, in quaternion startRot, in float3 targetPos, in quaternion targetRot, float deltaTime, float positionStabilization, float angleStabilization, out float3 resultPos, out quaternion resultRot) { }

	[BurstCompile]
	public static void StabilizeTransform$BurstManaged(in float3 startPos, in quaternion startRot, in float3 targetPos, in quaternion targetRot, float deltaTime, float positionStabilization, float angleStabilization, out float3 resultPos, out quaternion resultRot) { }

	protected void Update() { }

}

