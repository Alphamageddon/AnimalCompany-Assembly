namespace UnityEngine;

[NativeClass("UI::Canvas")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/UIStructs.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[RequireComponent(typeof(RectTransform))]
public sealed class Canvas : Behaviour
{
	internal sealed class WillRenderCanvases : MulticastDelegate
	{

		public WillRenderCanvases(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static WillRenderCanvases preWillRenderCanvases; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static WillRenderCanvases willRenderCanvases; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32> <externBeginRenderOverlays>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32, Int32> <externRenderOverlaysBefore>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32> <externEndRenderOverlays>k__BackingField; //Field offset: 0x20

	public static event WillRenderCanvases preWillRenderCanvases
	{
		[CompilerGenerated]
		 add { } //Length: 184
		[CompilerGenerated]
		 remove { } //Length: 184
	}

	public static event WillRenderCanvases willRenderCanvases
	{
		[CompilerGenerated]
		 add { } //Length: 188
		[CompilerGenerated]
		 remove { } //Length: 188
	}

	public AdditionalCanvasShaderChannels additionalShaderChannels
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	internal static Action<Int32> externBeginRenderOverlays
	{
		[CompilerGenerated]
		internal get { } //Length: 72
		[CompilerGenerated]
		internal set { } //Length: 76
	}

	internal static Action<Int32> externEndRenderOverlays
	{
		[CompilerGenerated]
		internal get { } //Length: 72
		[CompilerGenerated]
		internal set { } //Length: 76
	}

	internal static Action<Int32, Int32> externRenderOverlaysBefore
	{
		[CompilerGenerated]
		internal get { } //Length: 72
		[CompilerGenerated]
		internal set { } //Length: 76
	}

	public bool isRootCanvas
	{
		 get { } //Length: 60
	}

	[NativeProperty("SortingBucketNormalizedSize", False, TargetType::Function (0))]
	public float normalizedSortingGridSize
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public bool overridePixelPerfect
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public bool overrideSorting
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public bool pixelPerfect
	{
		 get { } //Length: 60
	}

	public Rect pixelRect
	{
		 get { } //Length: 88
	}

	public float planeDistance
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public float referencePixelsPerUnit
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public Vector2 renderingDisplaySize
	{
		 get { } //Length: 76
	}

	public RenderMode renderMode
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public int renderOrder
	{
		 get { } //Length: 60
	}

	public Canvas rootCanvas
	{
		 get { } //Length: 60
	}

	public float scaleFactor
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public int sortingLayerID
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public string sortingLayerName
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public int sortingOrder
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public int targetDisplay
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	[NativeProperty("Camera", False, TargetType::Function (0))]
	public Camera worldCamera
	{
		 get { } //Length: 60
	}

	public Canvas() { }

	[CompilerGenerated]
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	[CompilerGenerated]
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	[RequiredByNativeCode]
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[RequiredByNativeCode]
	private static void EndRenderExtraOverlays(int displayIndex) { }

	public static void ForceUpdateCanvases() { }

	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	[CompilerGenerated]
	internal static Action<Int32> get_externBeginRenderOverlays() { }

	[CompilerGenerated]
	internal static Action<Int32> get_externEndRenderOverlays() { }

	[CompilerGenerated]
	internal static Action<Int32, Int32> get_externRenderOverlaysBefore() { }

	public bool get_isRootCanvas() { }

	public float get_normalizedSortingGridSize() { }

	public bool get_overridePixelPerfect() { }

	public bool get_overrideSorting() { }

	public bool get_pixelPerfect() { }

	public Rect get_pixelRect() { }

	private void get_pixelRect_Injected(out Rect ret) { }

	public float get_planeDistance() { }

	public float get_referencePixelsPerUnit() { }

	public Vector2 get_renderingDisplaySize() { }

	private void get_renderingDisplaySize_Injected(out Vector2 ret) { }

	public RenderMode get_renderMode() { }

	public int get_renderOrder() { }

	public Canvas get_rootCanvas() { }

	public float get_scaleFactor() { }

	public int get_sortingLayerID() { }

	public string get_sortingLayerName() { }

	public int get_sortingOrder() { }

	public int get_targetDisplay() { }

	public Camera get_worldCamera() { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	public static Material GetETC1SupportedCanvasMaterial() { }

	[CompilerGenerated]
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	[CompilerGenerated]
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	[RequiredByNativeCode]
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[RequiredByNativeCode]
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCode]
	private static void SendWillRenderCanvases() { }

	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	[CompilerGenerated]
	internal static void set_externBeginRenderOverlays(Action<Int32> value) { }

	[CompilerGenerated]
	internal static void set_externEndRenderOverlays(Action<Int32> value) { }

	[CompilerGenerated]
	internal static void set_externRenderOverlaysBefore(Action<Int32, Int32> value) { }

	public void set_normalizedSortingGridSize(float value) { }

	public void set_overridePixelPerfect(bool value) { }

	public void set_overrideSorting(bool value) { }

	public void set_planeDistance(float value) { }

	public void set_referencePixelsPerUnit(float value) { }

	public void set_renderMode(RenderMode value) { }

	public void set_scaleFactor(float value) { }

	public void set_sortingLayerID(int value) { }

	public void set_sortingLayerName(string value) { }

	public void set_sortingOrder(int value) { }

	public void set_targetDisplay(int value) { }

	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	internal static void SetExternalCanvasEnabled(bool enabled) { }

}

