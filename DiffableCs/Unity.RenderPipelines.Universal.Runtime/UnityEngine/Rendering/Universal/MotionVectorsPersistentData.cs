namespace UnityEngine.Rendering.Universal;

internal sealed class MotionVectorsPersistentData
{
	private const int k_EyeCount = 2; //Field offset: 0x0
	private readonly Matrix4x4[] m_ViewProjection; //Field offset: 0x10
	private readonly Matrix4x4[] m_PreviousViewProjection; //Field offset: 0x18
	private readonly Int32[] m_LastFrameIndex; //Field offset: 0x20
	private readonly Single[] m_PrevAspectRatio; //Field offset: 0x28

	internal int lastFrameIndex
	{
		internal get { } //Length: 40
	}

	internal Matrix4x4 previousViewProjection
	{
		internal get { } //Length: 52
	}

	internal Matrix4x4[] previousViewProjectionStereo
	{
		internal get { } //Length: 8
	}

	internal Matrix4x4 viewProjection
	{
		internal get { } //Length: 52
	}

	internal Matrix4x4[] viewProjectionStereo
	{
		internal get { } //Length: 8
	}

	internal MotionVectorsPersistentData() { }

	internal int get_lastFrameIndex() { }

	internal Matrix4x4 get_previousViewProjection() { }

	internal Matrix4x4[] get_previousViewProjectionStereo() { }

	internal Matrix4x4 get_viewProjection() { }

	internal Matrix4x4[] get_viewProjectionStereo() { }

	internal int GetXRMultiPassId(ref CameraData cameraData) { }

	public void Reset() { }

	public void Update(ref CameraData cameraData) { }

}

