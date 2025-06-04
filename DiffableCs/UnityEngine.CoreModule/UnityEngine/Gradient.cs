namespace UnityEngine;

[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
[RequiredByNativeCode]
public class Gradient : IEquatable<Gradient>
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public GradientAlphaKey[] alphaKeys
	{
		[FreeFunction("Gradient_Bindings::SetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
		 set { } //Length: 68
	}

	public GradientColorKey[] colorKeys
	{
		[FreeFunction("Gradient_Bindings::SetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
		 set { } //Length: 68
	}

	[RequiredByNativeCode]
	public Gradient() { }

	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	private void Cleanup() { }

	public virtual bool Equals(object o) { }

	public override bool Equals(Gradient other) { }

	[FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = True, HasExplicitThis = True)]
	public Color Evaluate(float time) { }

	private void Evaluate_Injected(float time, out Color ret) { }

	protected virtual void Finalize() { }

	public virtual int GetHashCode() { }

	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	private static IntPtr Init() { }

	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	private bool Internal_Equals(IntPtr other) { }

	[FreeFunction("Gradient_Bindings::SetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public void set_alphaKeys(GradientAlphaKey[] value) { }

	[FreeFunction("Gradient_Bindings::SetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public void set_colorKeys(GradientColorKey[] value) { }

	[FreeFunction(Name = "Gradient_Bindings::SetKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

}

