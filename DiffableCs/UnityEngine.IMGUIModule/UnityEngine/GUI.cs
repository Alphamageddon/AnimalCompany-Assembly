namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
public class GUI
{
	internal sealed class WindowFunction : MulticastDelegate
	{

		public WindowFunction(object object, IntPtr method) { }

		public override void Invoke(int id) { }

	}

	private static int s_HotTextField; //Field offset: 0x0
	private static readonly int s_BoxHash; //Field offset: 0x4
	private static readonly int s_ButonHash; //Field offset: 0x8
	private static readonly int s_RepeatButtonHash; //Field offset: 0xC
	private static readonly int s_ToggleHash; //Field offset: 0x10
	private static readonly int s_ButtonGridHash; //Field offset: 0x14
	private static readonly int s_SliderHash; //Field offset: 0x18
	private static readonly int s_BeginGroupHash; //Field offset: 0x1C
	private static readonly int s_ScrollviewHash; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static int <scrollTroughSide>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static DateTime <nextScrollStepTime>k__BackingField; //Field offset: 0x28
	private static GUISkin s_Skin; //Field offset: 0x30
	internal static Rect s_ToolTipRect; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static GenericStack <scrollViewStates>k__BackingField; //Field offset: 0x48

	public static Color backgroundColor
	{
		 get { } //Length: 136
		 set { } //Length: 132
	}

	internal static Material blendMaterial
	{
		[FreeFunction("GetGUIBlendMaterial")]
		internal get { } //Length: 40
	}

	internal static Material blitMaterial
	{
		[FreeFunction("GetGUIBlitMaterial")]
		internal get { } //Length: 40
	}

	public static bool changed
	{
		 get { } //Length: 40
		 set { } //Length: 60
	}

	public static Color color
	{
		 get { } //Length: 136
		 set { } //Length: 132
	}

	public static Color contentColor
	{
		 get { } //Length: 136
		 set { } //Length: 132
	}

	public static bool enabled
	{
		 get { } //Length: 40
		 set { } //Length: 60
	}

	public static Matrix4x4 matrix
	{
		 get { } //Length: 108
		 set { } //Length: 76
	}

	internal static DateTime nextScrollStepTime
	{
		[CompilerGenerated]
		internal get { } //Length: 88
		[CompilerGenerated]
		internal set { } //Length: 92
	}

	internal static Material roundedRectMaterial
	{
		[FreeFunction("GetGUIRoundedRectMaterial")]
		internal get { } //Length: 40
	}

	internal static Material roundedRectWithColorPerBorderMaterial
	{
		[FreeFunction("GetGUIRoundedRectWithColorPerBorderMaterial")]
		internal get { } //Length: 40
	}

	internal static int scrollTroughSide
	{
		[CompilerGenerated]
		internal get { } //Length: 88
		[CompilerGenerated]
		internal set { } //Length: 92
	}

	internal static GenericStack scrollViewStates
	{
		[CompilerGenerated]
		internal get { } //Length: 88
	}

	public static GUISkin skin
	{
		 get { } //Length: 128
		 set { } //Length: 124
	}

	internal static bool usePageScrollbars
	{
		internal get { } //Length: 40
	}

	private static GUI() { }

	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	public static void Box(Rect position, string text) { }

	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	[RequiredByNativeCode]
	internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	internal static void DoSetSkin(GUISkin newSkin) { }

	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) { }

	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) { }

	public static void DragWindow(Rect position) { }

	public static void DragWindow() { }

	private static void DragWindow_Injected(ref Rect position) { }

	public static void DrawTexture(Rect position, Texture image) { }

	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	public static void EndGroup() { }

	public static Color get_backgroundColor() { }

	private static void get_backgroundColor_Injected(out Color ret) { }

	[FreeFunction("GetGUIBlendMaterial")]
	internal static Material get_blendMaterial() { }

	[FreeFunction("GetGUIBlitMaterial")]
	internal static Material get_blitMaterial() { }

	public static bool get_changed() { }

	public static Color get_color() { }

	private static void get_color_Injected(out Color ret) { }

	public static Color get_contentColor() { }

	private static void get_contentColor_Injected(out Color ret) { }

	public static bool get_enabled() { }

	public static Matrix4x4 get_matrix() { }

	[CompilerGenerated]
	internal static DateTime get_nextScrollStepTime() { }

	[FreeFunction("GetGUIRoundedRectMaterial")]
	internal static Material get_roundedRectMaterial() { }

	[FreeFunction("GetGUIRoundedRectWithColorPerBorderMaterial")]
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	[CompilerGenerated]
	internal static int get_scrollTroughSide() { }

	[CompilerGenerated]
	internal static GenericStack get_scrollViewStates() { }

	public static GUISkin get_skin() { }

	internal static bool get_usePageScrollbars() { }

	internal static void GrabMouseControl(int id) { }

	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	private static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor) { }

	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) { }

	internal static bool HasMouseControl(int id) { }

	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) { }

	private static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret) { }

	internal static void InternalRepaintEditorWindow() { }

	public static void Label(Rect position, string text) { }

	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	internal static string PasswordFieldGetStrToShow(string password, char maskChar) { }

	internal static void ReleaseMouseControl() { }

	public static void set_backgroundColor(Color value) { }

	private static void set_backgroundColor_Injected(ref Color value) { }

	public static void set_changed(bool value) { }

	public static void set_color(Color value) { }

	private static void set_color_Injected(ref Color value) { }

	public static void set_contentColor(Color value) { }

	private static void set_contentColor_Injected(ref Color value) { }

	public static void set_enabled(bool value) { }

	public static void set_matrix(Matrix4x4 value) { }

	[CompilerGenerated]
	internal static void set_nextScrollStepTime(DateTime value) { }

	[CompilerGenerated]
	internal static void set_scrollTroughSide(int value) { }

	public static void set_skin(GUISkin value) { }

	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null) { }

	public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

	public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style) { }

}

