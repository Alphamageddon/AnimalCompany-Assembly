namespace UnityEngine.XR.Interaction.Toolkit.Transformers;

[BurstCompile]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer.html")]
public class XRSocketGrabTransformer : IXRGrabTransformer
{
	public static class CalculateScaleToFit_00000C23$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static CalculateScaleToFit_00000C23$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 boundsSize, in float3 fixedSize, in float3 initialScale, float epsilon, out float3 newScale) { }

	}

	internal sealed class CalculateScaleToFit_00000C23$PostfixBurstDelegate : MulticastDelegate
	{

		public CalculateScaleToFit_00000C23$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 boundsSize, in float3 fixedSize, in float3 initialScale, float epsilon, out float3 newScale, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 boundsSize, in float3 fixedSize, in float3 initialScale, float epsilon, out float3 newScale) { }

	}

	public static class FastCalculateRadiusOffset_00000C20$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static FastCalculateRadiusOffset_00000C20$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static float Invoke(in float3 initialScale, in float3 targetScale, in float3 initialBoundsSize, float innerRadius) { }

	}

	internal sealed class FastCalculateRadiusOffset_00000C20$PostfixBurstDelegate : MulticastDelegate
	{

		public FastCalculateRadiusOffset_00000C20$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 initialScale, in float3 targetScale, in float3 initialBoundsSize, float innerRadius, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		public override float EndInvoke(IAsyncResult unnamed_param_0) { }

		public override float Invoke(in float3 initialScale, in float3 targetScale, in float3 initialBoundsSize, float innerRadius) { }

	}

	public static class FastComputeNewTrackedPose_00000C21$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static FastComputeNewTrackedPose_00000C21$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 interactorAttachPos, in quaternion interactorAttachRot, in float3 positionOffset, in quaternion interactableRot, in quaternion interactableAttachRot, out float3 targetPos, out quaternion targetRot) { }

	}

	internal sealed class FastComputeNewTrackedPose_00000C21$PostfixBurstDelegate : MulticastDelegate
	{

		public FastComputeNewTrackedPose_00000C21$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 interactorAttachPos, in quaternion interactorAttachRot, in float3 positionOffset, in quaternion interactableRot, in quaternion interactableAttachRot, out float3 targetPos, out quaternion targetRot, AsyncCallback unnamed_param_7, object unnamed_param_8) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 interactorAttachPos, in quaternion interactorAttachRot, in float3 positionOffset, in quaternion interactableRot, in quaternion interactableAttachRot, out float3 targetPos, out quaternion targetRot) { }

	}

	public static class IsWithinRadius_00000C22$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static IsWithinRadius_00000C22$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static bool Invoke(in float3 a, in float3 b, float radius) { }

	}

	internal sealed class IsWithinRadius_00000C22$PostfixBurstDelegate : MulticastDelegate
	{

		public IsWithinRadius_00000C22$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 a, in float3 b, float radius, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override bool EndInvoke(IAsyncResult unnamed_param_0) { }

		public override bool Invoke(in float3 a, in float3 b, float radius) { }

	}

	private const float k_SocketSnappingAxisTolerance = 0.01; //Field offset: 0x0
	[CompilerGenerated]
	private bool <canProcess>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private float <socketSnappingRadius>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private SocketScaleMode <scaleMode>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float3 <fixedScale>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private float3 <targetBoundsSize>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private IXRInteractor <socketInteractor>k__BackingField; //Field offset: 0x38
	private readonly Dictionary<IXRInteractable, float3> m_InitialScale; //Field offset: 0x40
	private readonly Dictionary<IXRInteractable, float3> m_InteractableBoundsSize; //Field offset: 0x48

	public override bool canProcess
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public float3 fixedScale
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public SocketScaleMode scaleMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public IXRInteractor socketInteractor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float socketSnappingRadius
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float3 targetBoundsSize
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public XRSocketGrabTransformer() { }

	[BurstCompile]
	private static void CalculateScaleToFit(in float3 boundsSize, in float3 fixedSize, in float3 initialScale, float epsilon, out float3 newScale) { }

	[BurstCompile]
	public static void CalculateScaleToFit$BurstManaged(in float3 boundsSize, in float3 fixedSize, in float3 initialScale, float epsilon, out float3 newScale) { }

	private float3 ComputeSocketTargetScale(IXRInteractable interactable, in float3 initialInteractableScale) { }

	[BurstCompile]
	private static float FastCalculateRadiusOffset(in float3 initialScale, in float3 targetScale, in float3 initialBoundsSize, float innerRadius) { }

	[BurstCompile]
	public static float FastCalculateRadiusOffset$BurstManaged(in float3 initialScale, in float3 targetScale, in float3 initialBoundsSize, float innerRadius) { }

	[BurstCompile]
	private static void FastComputeNewTrackedPose(in float3 interactorAttachPos, in quaternion interactorAttachRot, in float3 positionOffset, in quaternion interactableRot, in quaternion interactableAttachRot, out float3 targetPos, out quaternion targetRot) { }

	[BurstCompile]
	public static void FastComputeNewTrackedPose$BurstManaged(in float3 interactorAttachPos, in quaternion interactorAttachRot, in float3 positionOffset, in quaternion interactableRot, in quaternion interactableAttachRot, out float3 targetPos, out quaternion targetRot) { }

	[CompilerGenerated]
	public override bool get_canProcess() { }

	[CompilerGenerated]
	public float3 get_fixedScale() { }

	[CompilerGenerated]
	public SocketScaleMode get_scaleMode() { }

	[CompilerGenerated]
	public IXRInteractor get_socketInteractor() { }

	[CompilerGenerated]
	public float get_socketSnappingRadius() { }

	[CompilerGenerated]
	public float3 get_targetBoundsSize() { }

	private static bool GetTargetPoseForInteractable(IXRInteractable interactable, IXRInteractor interactor, out Pose targetPose) { }

	[BurstCompile]
	private static bool IsWithinRadius(in float3 a, in float3 b, float radius) { }

	[BurstCompile]
	public static bool IsWithinRadius$BurstManaged(in float3 a, in float3 b, float radius) { }

	public override void OnGrab(XRGrabInteractable grabInteractable) { }

	public override void OnGrabCountChanged(XRGrabInteractable grabInteractable, Pose targetPose, Vector3 localScale) { }

	public override void OnLink(XRGrabInteractable grabInteractable) { }

	public override void OnUnlink(XRGrabInteractable grabInteractable) { }

	public override void Process(XRGrabInteractable grabInteractable, UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale) { }

	private bool RegisterInteractableScale(IXRInteractable targetInteractable, Vector3 scale) { }

	[CompilerGenerated]
	public void set_canProcess(bool value) { }

	[CompilerGenerated]
	public void set_fixedScale(float3 value) { }

	[CompilerGenerated]
	public void set_scaleMode(SocketScaleMode value) { }

	[CompilerGenerated]
	public void set_socketInteractor(IXRInteractor value) { }

	[CompilerGenerated]
	public void set_socketSnappingRadius(float value) { }

	[CompilerGenerated]
	public void set_targetBoundsSize(float3 value) { }

	private static void UpdateTargetWithoutScale(XRGrabInteractable grabInteractable, IXRInteractor interactor, float snappingRadius, ref Pose targetPose) { }

	private static void UpdateTargetWithScale(XRGrabInteractable grabInteractable, IXRInteractor interactor, float innerRadius, in float3 initialScale, in float3 initialBounds, in float3 targetScale, ref Pose targetPose, ref Vector3 localScale) { }

}

