namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
public struct TransformStreamHandle
{
	private uint m_AnimatorBindingsVersion; //Field offset: 0x0
	private int handleIndex; //Field offset: 0x4
	private int skeletonIndex; //Field offset: 0x8

	internal uint animatorBindingsVersion
	{
		internal get { } //Length: 8
	}

	private bool createdByNative
	{
		private get { } //Length: 16
	}

	private bool hasHandleIndex
	{
		private get { } //Length: 16
	}

	private bool hasSkeletonIndex
	{
		private get { } //Length: 16
	}

	private void CheckIsValidAndResolve(ref AnimationStream stream) { }

	internal uint get_animatorBindingsVersion() { }

	private bool get_createdByNative() { }

	private bool get_hasHandleIndex() { }

	private bool get_hasSkeletonIndex() { }

	public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::GetGlobalTRInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation) { }

	private static void GetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation) { }

	public Vector3 GetLocalPosition(AnimationStream stream) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalPositionInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private Vector3 GetLocalPositionInternal(ref AnimationStream stream) { }

	private static void GetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret) { }

	public Quaternion GetLocalRotation(AnimationStream stream) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalRotationInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private Quaternion GetLocalRotationInternal(ref AnimationStream stream) { }

	private static void GetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret) { }

	public Vector3 GetLocalScale(AnimationStream stream) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalScaleInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private Vector3 GetLocalScaleInternal(ref AnimationStream stream) { }

	private static void GetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret) { }

	public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalTRSInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) { }

	private static void GetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) { }

	public Vector3 GetPosition(AnimationStream stream) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::GetPositionInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private Vector3 GetPositionInternal(ref AnimationStream stream) { }

	private static void GetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret) { }

	public Quaternion GetRotation(AnimationStream stream) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::GetRotationInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private Quaternion GetRotationInternal(ref AnimationStream stream) { }

	private static void GetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret) { }

	public bool IsResolved(AnimationStream stream) { }

	private bool IsResolvedInternal(ref AnimationStream stream) { }

	private bool IsSameVersionAsStream(ref AnimationStream stream) { }

	public bool IsValid(AnimationStream stream) { }

	private bool IsValidInternal(ref AnimationStream stream) { }

	public void Resolve(AnimationStream stream) { }

	[NativeMethod(Name = "Resolve", IsThreadSafe = True)]
	private void ResolveInternal(ref AnimationStream stream) { }

	private static void ResolveInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream) { }

	public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::SetGlobalTRInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private void SetGlobalTRInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask) { }

	private static void SetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position, ref Quaternion rotation, bool useMask) { }

	public void SetLocalPosition(AnimationStream stream, Vector3 position) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalPositionInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private void SetLocalPositionInternal(ref AnimationStream stream, Vector3 position) { }

	private static void SetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position) { }

	public void SetLocalRotation(AnimationStream stream, Quaternion rotation) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalRotationInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private void SetLocalRotationInternal(ref AnimationStream stream, Quaternion rotation) { }

	private static void SetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation) { }

	public void SetLocalScale(AnimationStream stream, Vector3 scale) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalScaleInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private void SetLocalScaleInternal(ref AnimationStream stream, Vector3 scale) { }

	private static void SetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 scale) { }

	public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalTRSInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private void SetLocalTRSInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask) { }

	private static void SetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale, bool useMask) { }

	public void SetPosition(AnimationStream stream, Vector3 position) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::SetPositionInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private void SetPositionInternal(ref AnimationStream stream, Vector3 position) { }

	private static void SetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Vector3 position) { }

	public void SetRotation(AnimationStream stream, Quaternion rotation) { }

	[NativeMethod(Name = "TransformStreamHandleBindings::SetRotationInternal", IsFreeFunction = True, HasExplicitThis = True, IsThreadSafe = True)]
	private void SetRotationInternal(ref AnimationStream stream, Quaternion rotation) { }

	private static void SetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation) { }

}

