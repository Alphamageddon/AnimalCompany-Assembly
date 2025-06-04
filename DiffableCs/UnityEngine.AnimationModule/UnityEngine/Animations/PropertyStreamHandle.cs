namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
public struct PropertyStreamHandle
{
	private uint m_AnimatorBindingsVersion; //Field offset: 0x0
	private int handleIndex; //Field offset: 0x4
	private int valueArrayIndex; //Field offset: 0x8
	private int bindType; //Field offset: 0xC

	internal uint animatorBindingsVersion
	{
		internal get { } //Length: 8
	}

	private bool createdByNative
	{
		private get { } //Length: 16
	}

	private bool hasBindType
	{
		private get { } //Length: 16
	}

	private bool hasHandleIndex
	{
		private get { } //Length: 16
	}

	private bool hasValueArrayIndex
	{
		private get { } //Length: 16
	}

	private void CheckIsValidAndResolve(ref AnimationStream stream) { }

	internal uint get_animatorBindingsVersion() { }

	private bool get_createdByNative() { }

	private bool get_hasBindType() { }

	private bool get_hasHandleIndex() { }

	private bool get_hasValueArrayIndex() { }

	public bool GetBool(AnimationStream stream) { }

	[NativeMethod(Name = "GetBool", IsThreadSafe = True)]
	private bool GetBoolInternal(ref AnimationStream stream) { }

	private static bool GetBoolInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) { }

	public float GetFloat(AnimationStream stream) { }

	[NativeMethod(Name = "GetFloat", IsThreadSafe = True)]
	private float GetFloatInternal(ref AnimationStream stream) { }

	private static float GetFloatInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) { }

	public int GetInt(AnimationStream stream) { }

	[NativeMethod(Name = "GetInt", IsThreadSafe = True)]
	private int GetIntInternal(ref AnimationStream stream) { }

	private static int GetIntInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) { }

	private bool IsResolvedInternal(ref AnimationStream stream) { }

	private bool IsSameVersionAsStream(ref AnimationStream stream) { }

	private bool IsValidInternal(ref AnimationStream stream) { }

	[NativeMethod(Name = "Resolve", IsThreadSafe = True)]
	private void ResolveInternal(ref AnimationStream stream) { }

	private static void ResolveInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream) { }

	public void SetBool(AnimationStream stream, bool value) { }

	[NativeMethod(Name = "SetBool", IsThreadSafe = True)]
	private void SetBoolInternal(ref AnimationStream stream, bool value) { }

	private static void SetBoolInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, bool value) { }

	public void SetFloat(AnimationStream stream, float value) { }

	[NativeMethod(Name = "SetFloat", IsThreadSafe = True)]
	private void SetFloatInternal(ref AnimationStream stream, float value) { }

	private static void SetFloatInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, float value) { }

	public void SetInt(AnimationStream stream, int value) { }

	[NativeMethod(Name = "SetInt", IsThreadSafe = True)]
	private void SetIntInternal(ref AnimationStream stream, int value) { }

	private static void SetIntInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, int value) { }

}

