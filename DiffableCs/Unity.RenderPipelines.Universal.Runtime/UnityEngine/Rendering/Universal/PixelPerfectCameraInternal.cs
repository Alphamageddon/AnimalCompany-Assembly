namespace UnityEngine.Rendering.Universal;

internal class PixelPerfectCameraInternal : ISerializationCallbackReceiver
{
	private IPixelPerfectCamera m_Component; //Field offset: 0x10
	private PixelPerfectCamera m_SerializableComponent; //Field offset: 0x18
	internal float originalOrthoSize; //Field offset: 0x20
	internal bool hasPostProcessLayer; //Field offset: 0x24
	internal bool cropFrameXAndY; //Field offset: 0x25
	internal bool cropFrameXOrY; //Field offset: 0x26
	internal bool useStretchFill; //Field offset: 0x27
	internal int zoom; //Field offset: 0x28
	internal bool useOffscreenRT; //Field offset: 0x2C
	internal int offscreenRTWidth; //Field offset: 0x30
	internal int offscreenRTHeight; //Field offset: 0x34
	internal Rect pixelRect; //Field offset: 0x38
	internal float orthoSize; //Field offset: 0x48
	internal float unitsPerPixel; //Field offset: 0x4C
	internal int cinemachineVCamZoom; //Field offset: 0x50
	internal bool requiresUpscaling; //Field offset: 0x54

	internal PixelPerfectCameraInternal(IPixelPerfectCamera component) { }

	internal void CalculateCameraProperties(int screenWidth, int screenHeight) { }

	internal Rect CalculateFinalBlitPixelRect(int screenWidth, int screenHeight) { }

	internal float CorrectCinemachineOrthoSize(float targetOrthoSize) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

}

