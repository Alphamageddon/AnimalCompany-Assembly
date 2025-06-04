namespace UnityEngine.Experimental.Rendering.Universal;

[AddComponentMenu("Rendering/2D/Pixel Perfect Camera")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2d-pixelperfect.html%23properties")]
[MovedFrom("UnityEngine.Experimental.Rendering")]
[RequireComponent(typeof(Camera))]
public class PixelPerfectCamera : MonoBehaviour, IPixelPerfectCamera, ISerializationCallbackReceiver
{
	private enum ComponentVersions
	{
		Version_Unserialized = 0,
		Version_1 = 1,
	}

	internal enum CropFrame
	{
		None = 0,
		Pillarbox = 1,
		Letterbox = 2,
		Windowbox = 3,
		StretchFill = 4,
	}

	internal enum GridSnapping
	{
		None = 0,
		PixelSnapping = 1,
		UpscaleRenderTexture = 2,
	}

	internal enum PixelPerfectFilterMode
	{
		RetroAA = 0,
		Point = 1,
	}

	[SerializeField]
	private int m_AssetsPPU; //Field offset: 0x20
	[SerializeField]
	private int m_RefResolutionX; //Field offset: 0x24
	[SerializeField]
	private int m_RefResolutionY; //Field offset: 0x28
	[SerializeField]
	private CropFrame m_CropFrame; //Field offset: 0x2C
	[SerializeField]
	private GridSnapping m_GridSnapping; //Field offset: 0x30
	[SerializeField]
	private PixelPerfectFilterMode m_FilterMode; //Field offset: 0x34
	private Camera m_Camera; //Field offset: 0x38
	private PixelPerfectCameraInternal m_Internal; //Field offset: 0x40
	private bool m_CinemachineCompatibilityMode; //Field offset: 0x48

	public override int assetsPPU
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	private Vector2Int cameraRTSize
	{
		private get { } //Length: 204
	}

	public CropFrame cropFrame
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("Use cropFrame instead", False)]
	public override bool cropFrameX
	{
		 get { } //Length: 44
		 set { } //Length: 76
	}

	[Obsolete("Use cropFrame instead", False)]
	public override bool cropFrameY
	{
		 get { } //Length: 20
		 set { } //Length: 76
	}

	internal FilterMode finalBlitFilterMode
	{
		internal get { } //Length: 16
	}

	public GridSnapping gridSnapping
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	internal Vector2Int offscreenRTSize
	{
		internal get { } //Length: 28
	}

	public float orthographicSize
	{
		 get { } //Length: 28
	}

	public int pixelRatio
	{
		 get { } //Length: 76
	}

	[Obsolete("Use gridSnapping instead", False)]
	public override bool pixelSnapping
	{
		 get { } //Length: 16
		 set { } //Length: 28
	}

	public override int refResolutionX
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public override int refResolutionY
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public bool requiresUpscalePass
	{
		 get { } //Length: 28
	}

	[Obsolete("Use cropFrame instead", False)]
	public override bool stretchFill
	{
		 get { } //Length: 16
		 set { } //Length: 20
	}

	[Obsolete("Use gridSnapping instead", False)]
	public override bool upscaleRT
	{
		 get { } //Length: 16
		 set { } //Length: 36
	}

	public PixelPerfectCamera() { }

	private void Awake() { }

	public float CorrectCinemachineOrthoSize(float targetOrthoSize) { }

	public override int get_assetsPPU() { }

	private Vector2Int get_cameraRTSize() { }

	public CropFrame get_cropFrame() { }

	public override bool get_cropFrameX() { }

	public override bool get_cropFrameY() { }

	internal FilterMode get_finalBlitFilterMode() { }

	public GridSnapping get_gridSnapping() { }

	internal Vector2Int get_offscreenRTSize() { }

	public float get_orthographicSize() { }

	public int get_pixelRatio() { }

	public override bool get_pixelSnapping() { }

	public override int get_refResolutionX() { }

	public override int get_refResolutionY() { }

	public bool get_requiresUpscalePass() { }

	public override bool get_stretchFill() { }

	public override bool get_upscaleRT() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	internal void OnDisable() { }

	private void OnEnable() { }

	private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	private void PixelSnap() { }

	public Vector3 RoundToPixel(Vector3 position) { }

	public override void set_assetsPPU(int value) { }

	public void set_cropFrame(CropFrame value) { }

	public override void set_cropFrameX(bool value) { }

	public override void set_cropFrameY(bool value) { }

	public void set_gridSnapping(GridSnapping value) { }

	public override void set_pixelSnapping(bool value) { }

	public override void set_refResolutionX(int value) { }

	public override void set_refResolutionY(int value) { }

	public override void set_stretchFill(bool value) { }

	public override void set_upscaleRT(bool value) { }

	private void UpdateCameraProperties() { }

}

