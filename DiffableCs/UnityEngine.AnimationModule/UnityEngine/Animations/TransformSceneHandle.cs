namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
public struct TransformSceneHandle
{
	private uint valid; //Field offset: 0x0
	private int transformSceneHandleDefinitionIndex; //Field offset: 0x4

	private bool createdByNative
	{
		private get { } //Length: 16
	}

	private bool hasTransformSceneHandleDefinitionIndex
	{
		private get { } //Length: 16
	}

	private void CheckIsValid(ref AnimationStream stream) { }

	private bool get_createdByNative() { }

	private bool get_hasTransformSceneHandleDefinitionIndex() { }

	public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation) { }

	[NativeMethod(Name = "TransformSceneHandleBindings::GetGlobalTRInternal", IsFreeFunction = True, IsThreadSafe = True, HasExplicitThis = True)]
	private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation) { }

	private static void GetGlobalTRInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation) { }

	public Vector3 GetLocalPosition(AnimationStream stream) { }

	[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalPositionInternal", IsFreeFunction = True, IsThreadSafe = True, HasExplicitThis = True)]
	private Vector3 GetLocalPositionInternal(ref AnimationStream stream) { }

	private static void GetLocalPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret) { }

	public Quaternion GetLocalRotation(AnimationStream stream) { }

	[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalRotationInternal", IsFreeFunction = True, IsThreadSafe = True, HasExplicitThis = True)]
	private Quaternion GetLocalRotationInternal(ref AnimationStream stream) { }

	private static void GetLocalRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret) { }

	public Vector3 GetLocalScale(AnimationStream stream) { }

	[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalScaleInternal", IsFreeFunction = True, IsThreadSafe = True, HasExplicitThis = True)]
	private Vector3 GetLocalScaleInternal(ref AnimationStream stream) { }

	private static void GetLocalScaleInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret) { }

	public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) { }

	[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalTRSInternal", IsFreeFunction = True, IsThreadSafe = True, HasExplicitThis = True)]
	private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) { }

	private static void GetLocalTRSInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) { }

	public Vector3 GetPosition(AnimationStream stream) { }

	[NativeMethod(Name = "TransformSceneHandleBindings::GetPositionInternal", IsFreeFunction = True, IsThreadSafe = True, HasExplicitThis = True)]
	private Vector3 GetPositionInternal(ref AnimationStream stream) { }

	private static void GetPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret) { }

	public Quaternion GetRotation(AnimationStream stream) { }

	[NativeMethod(Name = "TransformSceneHandleBindings::GetRotationInternal", IsFreeFunction = True, IsThreadSafe = True, HasExplicitThis = True)]
	private Quaternion GetRotationInternal(ref AnimationStream stream) { }

	private static void GetRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret) { }

	[ThreadSafe]
	private bool HasValidTransform(ref AnimationStream stream) { }

	private static bool HasValidTransform_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream) { }

	public bool IsValid(AnimationStream stream) { }

}

