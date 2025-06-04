namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
[RequiredByNativeCode]
public class AnimationCurve : IEquatable<AnimationCurve>
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public Keyframe Item
	{
		 get { } //Length: 140
	}

	public Keyframe[] keys
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public int length
	{
		[NativeMethod("GetKeyCount", IsThreadSafe = True)]
		 get { } //Length: 60
	}

	public WrapMode postWrapMode
	{
		[NativeMethod("GetPostInfinity", IsThreadSafe = True)]
		 get { } //Length: 60
	}

	public WrapMode preWrapMode
	{
		[NativeMethod("GetPreInfinity", IsThreadSafe = True)]
		 get { } //Length: 60
	}

	[RequiredByNativeCode]
	public AnimationCurve() { }

	public AnimationCurve(Keyframe[] keys) { }

	public int AddKey(Keyframe key) { }

	[FreeFunction("AnimationCurveBindings::AddKeySmoothTangents", HasExplicitThis = True, IsThreadSafe = True)]
	public int AddKey(float time, float value) { }

	[NativeMethod("AddKey", IsThreadSafe = True)]
	private int AddKey_Internal(Keyframe key) { }

	private int AddKey_Internal_Injected(ref Keyframe key) { }

	[FreeFunction("AnimationCurveBindings::ClearKeys", HasExplicitThis = True, IsThreadSafe = True)]
	public void ClearKeys() { }

	public void CopyFrom(AnimationCurve other) { }

	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	public virtual bool Equals(object o) { }

	public override bool Equals(AnimationCurve other) { }

	[ThreadSafe]
	public float Evaluate(float time) { }

	protected virtual void Finalize() { }

	public Keyframe get_Item(int index) { }

	public Keyframe[] get_keys() { }

	[NativeMethod("GetKeyCount", IsThreadSafe = True)]
	public int get_length() { }

	[NativeMethod("GetPostInfinity", IsThreadSafe = True)]
	public WrapMode get_postWrapMode() { }

	[NativeMethod("GetPreInfinity", IsThreadSafe = True)]
	public WrapMode get_preWrapMode() { }

	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = True, IsThreadSafe = True)]
	public virtual int GetHashCode() { }

	[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	private Keyframe GetKey(int index) { }

	private void GetKey_Injected(int index, out Keyframe ret) { }

	[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = True, IsThreadSafe = True)]
	private Keyframe[] GetKeys() { }

	[FreeFunction("AnimationCurveBindings::Internal_CopyFrom", HasExplicitThis = True, IsThreadSafe = True)]
	private void Internal_CopyFrom(IntPtr other) { }

	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = True, IsThreadSafe = True)]
	private bool Internal_Equals(IntPtr other) { }

	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[FreeFunction("AnimationCurveBindings::MoveKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	public int MoveKey(int index, Keyframe key) { }

	private int MoveKey_Injected(int index, ref Keyframe key) { }

	[FreeFunction("AnimationCurveBindings::RemoveKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	public void RemoveKey(int index) { }

	public void set_keys(Keyframe[] value) { }

	[FreeFunction("AnimationCurveBindings::SetKeys", HasExplicitThis = True, IsThreadSafe = True)]
	private void SetKeys(Keyframe[] keys) { }

	[FreeFunction("AnimationCurveBindings::SmoothTangents", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	public void SmoothTangents(int index, float weight) { }

}

