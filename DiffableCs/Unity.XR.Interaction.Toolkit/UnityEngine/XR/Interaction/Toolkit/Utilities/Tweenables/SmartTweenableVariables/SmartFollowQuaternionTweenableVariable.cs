namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.SmartTweenableVariables;

[BurstCompile]
public class SmartFollowQuaternionTweenableVariable : QuaternionTweenableVariable
{
	public static class ComputeNewTweenTarget_000009C6$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static ComputeNewTweenTarget_000009C6$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float deltaTime, float angleOffsetDeg, float maxAngleAllowed, float lowerSpeed, float upperSpeed, out float newTweenTarget) { }

	}

	internal sealed class ComputeNewTweenTarget_000009C6$PostfixBurstDelegate : MulticastDelegate
	{

		public ComputeNewTweenTarget_000009C6$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float deltaTime, float angleOffsetDeg, float maxAngleAllowed, float lowerSpeed, float upperSpeed, out float newTweenTarget, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float deltaTime, float angleOffsetDeg, float maxAngleAllowed, float lowerSpeed, float upperSpeed, out float newTweenTarget) { }

	}

	[CompilerGenerated]
	private float <minAngleAllowed>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private float <maxAngleAllowed>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private float <minToMaxDelaySeconds>k__BackingField; //Field offset: 0x74
	private float m_LastUpdateTime; //Field offset: 0x78

	public float maxAngleAllowed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float minAngleAllowed
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

	public SmartFollowQuaternionTweenableVariable(float minAngleAllowed = 0.1, float maxAngleAllowed = 5, float minToMaxDelaySeconds = 3) { }

	[BurstCompile]
	private static void ComputeNewTweenTarget(float deltaTime, float angleOffsetDeg, float maxAngleAllowed, float lowerSpeed, float upperSpeed, out float newTweenTarget) { }

	[BurstCompile]
	public static void ComputeNewTweenTarget$BurstManaged(float deltaTime, float angleOffsetDeg, float maxAngleAllowed, float lowerSpeed, float upperSpeed, out float newTweenTarget) { }

	[CompilerGenerated]
	public float get_maxAngleAllowed() { }

	[CompilerGenerated]
	public float get_minAngleAllowed() { }

	[CompilerGenerated]
	public float get_minToMaxDelaySeconds() { }

	public void HandleSmartTween(float deltaTime, float lowerSpeed, float upperSpeed) { }

	public bool IsNewTargetWithinThreshold(Quaternion newTarget) { }

	protected virtual void OnTargetChanged(Quaternion newTarget) { }

	[CompilerGenerated]
	public void set_maxAngleAllowed(float value) { }

	[CompilerGenerated]
	public void set_minAngleAllowed(float value) { }

	[CompilerGenerated]
	public void set_minToMaxDelaySeconds(float value) { }

	public bool SetTargetWithinThreshold(Quaternion newTarget) { }

}

