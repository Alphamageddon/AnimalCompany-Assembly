namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/LineRenderer.h")]
public sealed class LineRenderer : Renderer
{

	public Gradient colorGradient
	{
		 set { } //Length: 68
	}

	public Color endColor
	{
		 get { } //Length: 88
		 set { } //Length: 84
	}

	public float endWidth
	{
		 set { } //Length: 76
	}

	public int numCapVertices
	{
		 set { } //Length: 68
	}

	[NativeProperty("PositionsCount")]
	public int positionCount
	{
		 set { } //Length: 68
	}

	public Color startColor
	{
		 get { } //Length: 88
		 set { } //Length: 84
	}

	public float startWidth
	{
		 set { } //Length: 76
	}

	public bool useWorldSpace
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public AnimationCurve widthCurve
	{
		 set { } //Length: 68
	}

	public float widthMultiplier
	{
		 set { } //Length: 76
	}

	public Color get_endColor() { }

	private void get_endColor_Injected(out Color ret) { }

	public Color get_startColor() { }

	private void get_startColor_Injected(out Color ret) { }

	public bool get_useWorldSpace() { }

	public void set_colorGradient(Gradient value) { }

	public void set_endColor(Color value) { }

	private void set_endColor_Injected(ref Color value) { }

	public void set_endWidth(float value) { }

	public void set_numCapVertices(int value) { }

	public void set_positionCount(int value) { }

	public void set_startColor(Color value) { }

	private void set_startColor_Injected(ref Color value) { }

	public void set_startWidth(float value) { }

	public void set_useWorldSpace(bool value) { }

	public void set_widthCurve(AnimationCurve value) { }

	public void set_widthMultiplier(float value) { }

	private void SetColorGradient(Gradient curve) { }

	[FreeFunction(Name = "LineRendererScripting::SetPositions", HasExplicitThis = True)]
	public void SetPositions(Vector3[] positions) { }

	public void SetPositions(NativeArray<Vector3> positions) { }

	[FreeFunction(Name = "LineRendererScripting::SetPositionsWithNativeContainer", HasExplicitThis = True)]
	private void SetPositionsWithNativeContainer(IntPtr positions, int count) { }

	private void SetWidthCurve(AnimationCurve curve) { }

}

