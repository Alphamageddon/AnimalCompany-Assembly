namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
[RequiredByNativeCode]
public struct AnimationStream
{
	private uint m_AnimatorBindingsVersion; //Field offset: 0x0
	private IntPtr constant; //Field offset: 0x8
	private IntPtr input; //Field offset: 0x10
	private IntPtr output; //Field offset: 0x18
	private IntPtr workspace; //Field offset: 0x20
	private IntPtr inputStreamAccessor; //Field offset: 0x28
	private IntPtr animationHandleBinder; //Field offset: 0x30

	internal uint animatorBindingsVersion
	{
		internal get { } //Length: 8
	}

	public float deltaTime
	{
		 get { } //Length: 64
	}

	public bool isValid
	{
		 get { } //Length: 132
	}

	internal void CheckIsValid() { }

	internal uint get_animatorBindingsVersion() { }

	public float get_deltaTime() { }

	public bool get_isValid() { }

	[NativeMethod(IsThreadSafe = True)]
	private float GetDeltaTime() { }

	private static float GetDeltaTime_Injected(ref AnimationStream _unity_self) { }

}

