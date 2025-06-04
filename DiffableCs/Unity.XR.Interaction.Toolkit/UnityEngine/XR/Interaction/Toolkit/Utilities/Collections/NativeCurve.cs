namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Collections;

public struct NativeCurve : IDisposable
{
	private NativeArray<Single> m_Values; //Field offset: 0x0
	private WrapMode m_PreWrapMode; //Field offset: 0x10
	private WrapMode m_PostWrapMode; //Field offset: 0x14

	public bool isCreated
	{
		 get { } //Length: 68
	}

	public override void Dispose() { }

	public float Evaluate(float t) { }

	public bool get_isCreated() { }

	private void InitializeValues(int count, Allocator allocator = 4) { }

	private float PingPong(float t, float length) { }

	private float Repeat(float t, float length) { }

	public void Update(AnimationCurve curve, int resolution) { }

}

