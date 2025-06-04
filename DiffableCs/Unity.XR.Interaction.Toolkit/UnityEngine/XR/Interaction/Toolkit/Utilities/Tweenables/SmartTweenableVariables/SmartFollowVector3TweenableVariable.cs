namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.SmartTweenableVariables;

[BurstCompile]
public class SmartFollowVector3TweenableVariable : Vector3TweenableVariable
{
	public static class ComputeNewTweenTarget_000009D2$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static ComputeNewTweenTarget_000009D2$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(in float3 currentValue, in float3 targetValue, float sqrMaxDistanceAllowed, float deltaTime, float lowerSpeed, float upperSpeed, out float newTweenTarget) { }

	}

	internal sealed class ComputeNewTweenTarget_000009D2$PostfixBurstDelegate : MulticastDelegate
	{

		public ComputeNewTweenTarget_000009D2$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 currentValue, in float3 targetValue, float sqrMaxDistanceAllowed, float deltaTime, float lowerSpeed, float upperSpeed, out float newTweenTarget, AsyncCallback unnamed_param_7, object unnamed_param_8) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(in float3 currentValue, in float3 targetValue, float sqrMaxDistanceAllowed, float deltaTime, float lowerSpeed, float upperSpeed, out float newTweenTarget) { }

	}

	public static class IsNewTargetWithinThreshold_000009D3$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static IsNewTargetWithinThreshold_000009D3$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static bool Invoke(in float3 currentValue, in float3 targetValue, float minDistanceAllowed, float maxDistanceAllowed, float timeSinceLastUpdate, float minToMaxDelaySeconds) { }

	}

	internal sealed class IsNewTargetWithinThreshold_000009D3$PostfixBurstDelegate : MulticastDelegate
	{

		public IsNewTargetWithinThreshold_000009D3$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(in float3 currentValue, in float3 targetValue, float minDistanceAllowed, float maxDistanceAllowed, float timeSinceLastUpdate, float minToMaxDelaySeconds, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		public override bool EndInvoke(IAsyncResult unnamed_param_0) { }

		public override bool Invoke(in float3 currentValue, in float3 targetValue, float minDistanceAllowed, float maxDistanceAllowed, float timeSinceLastUpdate, float minToMaxDelaySeconds) { }

	}

	[CompilerGenerated]
	private float <minDistanceAllowed>k__BackingField; //Field offset: 0xA8
	private float m_MaxDistanceAllowed; //Field offset: 0xAC
	[CompilerGenerated]
	private float <minToMaxDelaySeconds>k__BackingField; //Field offset: 0xB0
	private float m_SqrMaxDistanceAllowed; //Field offset: 0xB4
	private float m_LastUpdateTime; //Field offset: 0xB8

	public float maxDistanceAllowed
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public float minDistanceAllowed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float minToMaxDelaySeconds
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public SmartFollowVector3TweenableVariable(float minDistanceAllowed = 0.01, float maxDistanceAllowed = 0.3, float minToMaxDelaySeconds = 3) { }

	[BurstCompile]
	private static void ComputeNewTweenTarget(in float3 currentValue, in float3 targetValue, float sqrMaxDistanceAllowed, float deltaTime, float lowerSpeed, float upperSpeed, out float newTweenTarget) { }

	[BurstCompile]
	public static void ComputeNewTweenTarget$BurstManaged(in float3 currentValue, in float3 targetValue, float sqrMaxDistanceAllowed, float deltaTime, float lowerSpeed, float upperSpeed, out float newTweenTarget) { }

	public float get_maxDistanceAllowed() { }

	[CompilerGenerated]
	public float get_minDistanceAllowed() { }

	[CompilerGenerated]
	public float get_minToMaxDelaySeconds() { }

	public void HandleSmartTween(float deltaTime, float lowerSpeed, float upperSpeed) { }

	public bool IsNewTargetWithinThreshold(float3 newTarget) { }

	[BurstCompile]
	private static bool IsNewTargetWithinThreshold(in float3 currentValue, in float3 targetValue, float minDistanceAllowed, float maxDistanceAllowed, float timeSinceLastUpdate, float minToMaxDelaySeconds) { }

	[BurstCompile]
	public static bool IsNewTargetWithinThreshold$BurstManaged(in float3 currentValue, in float3 targetValue, float minDistanceAllowed, float maxDistanceAllowed, float timeSinceLastUpdate, float minToMaxDelaySeconds) { }

	protected virtual void OnTargetChanged(float3 newTarget) { }

	public void set_maxDistanceAllowed(float value) { }

	[CompilerGenerated]
	public void set_minDistanceAllowed(float value) { }

	[CompilerGenerated]
	public void set_minToMaxDelaySeconds(float value) { }

	public bool SetTargetWithinThreshold(float3 newTarget) { }

}

