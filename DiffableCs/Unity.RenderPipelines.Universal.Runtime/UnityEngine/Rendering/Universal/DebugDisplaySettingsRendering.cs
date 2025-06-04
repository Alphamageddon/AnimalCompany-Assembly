namespace UnityEngine.Rendering.Universal;

public class DebugDisplaySettingsRendering : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Rendering", order = 1)]
	public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsRendering>
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public DebugDisplaySettingsRendering data; //Field offset: 0x10

			public <>c__DisplayClass0_0() { }

			internal bool <.ctor>b__0() { }

		}


		public SettingsPanel(DebugDisplaySettingsRendering data) { }

	}

	private static class Strings
	{
		public const string RangeValidationSettingsContainerName = "Pixel Range Settings"; //Field offset: 0x0
		public static readonly NameAndTooltip MapOverlays; //Field offset: 0x0
		public static readonly NameAndTooltip MapSize; //Field offset: 0x10
		public static readonly NameAndTooltip AdditionalWireframeModes; //Field offset: 0x20
		public static readonly NameAndTooltip WireframeNotSupportedWarning; //Field offset: 0x30
		public static readonly NameAndTooltip OverdrawMode; //Field offset: 0x40
		public static readonly NameAndTooltip MaxOverdrawCount; //Field offset: 0x50
		public static readonly NameAndTooltip PostProcessing; //Field offset: 0x60
		public static readonly NameAndTooltip MSAA; //Field offset: 0x70
		public static readonly NameAndTooltip HDR; //Field offset: 0x80
		public static readonly NameAndTooltip TaaDebugMode; //Field offset: 0x90
		public static readonly NameAndTooltip PixelValidationMode; //Field offset: 0xA0
		public static readonly NameAndTooltip Channels; //Field offset: 0xB0
		public static readonly NameAndTooltip ValueRangeMin; //Field offset: 0xC0
		public static readonly NameAndTooltip ValueRangeMax; //Field offset: 0xD0

		private static Strings() { }

	}

	internal enum TaaDebugMode
	{
		None = 0,
		ShowRawFrame = 1,
		ShowRawFrameNoJitter = 2,
		ShowClampedHistory = 3,
	}

	public static class WidgetFactory
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<Int32> <>9__1_2; //Field offset: 0x8
			public static Func<Int32> <>9__1_3; //Field offset: 0x10
			public static Action<Field`1<Int32>, Int32> <>9__2_4; //Field offset: 0x18
			public static Func<Int32> <>9__5_3; //Field offset: 0x20
			public static Func<Int32> <>9__5_4; //Field offset: 0x28
			public static Action<Field`1<Int32>, Int32> <>9__9_4; //Field offset: 0x30
			public static Action<Field`1<Int32>, Int32> <>9__10_4; //Field offset: 0x38

			private static <>c() { }

			public <>c() { }

			internal void <CreateAdditionalWireframeShaderViews>b__2_4(Field<Int32> _, int _) { }

			internal int <CreateMapOverlaySize>b__1_2() { }

			internal int <CreateMapOverlaySize>b__1_3() { }

			internal int <CreateMaxOverdrawCount>b__5_3() { }

			internal int <CreateMaxOverdrawCount>b__5_4() { }

			internal void <CreatePixelValidationMode>b__10_4(Field<Int32> _, int _) { }

			internal void <CreateTaaDebugMode>b__9_4(Field<Int32> _, int _) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass0_0() { }

			internal int <CreateMapOverlays>b__0() { }

			internal void <CreateMapOverlays>b__1(int value) { }

			internal int <CreateMapOverlays>b__2() { }

			internal void <CreateMapOverlays>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass1_0() { }

			internal int <CreateMapOverlaySize>b__0() { }

			internal void <CreateMapOverlaySize>b__1(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass10_0() { }

			internal int <CreatePixelValidationMode>b__0() { }

			internal void <CreatePixelValidationMode>b__1(int value) { }

			internal int <CreatePixelValidationMode>b__2() { }

			internal void <CreatePixelValidationMode>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass11_0() { }

			internal int <CreatePixelValidationChannels>b__0() { }

			internal void <CreatePixelValidationChannels>b__1(int value) { }

			internal int <CreatePixelValidationChannels>b__2() { }

			internal void <CreatePixelValidationChannels>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass12_0() { }

			internal float <CreatePixelValueRangeMin>b__0() { }

			internal void <CreatePixelValueRangeMin>b__1(float value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass13_0() { }

			internal float <CreatePixelValueRangeMax>b__0() { }

			internal void <CreatePixelValueRangeMax>b__1(float value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass2_0() { }

			internal int <CreateAdditionalWireframeShaderViews>b__0() { }

			internal void <CreateAdditionalWireframeShaderViews>b__1(int value) { }

			internal int <CreateAdditionalWireframeShaderViews>b__2() { }

			internal void <CreateAdditionalWireframeShaderViews>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass3_0() { }

			internal bool <CreateWireframeNotSupportedWarning>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass4_0() { }

			internal int <CreateOverdrawMode>b__0() { }

			internal void <CreateOverdrawMode>b__1(int value) { }

			internal int <CreateOverdrawMode>b__2() { }

			internal void <CreateOverdrawMode>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass5_0() { }

			internal bool <CreateMaxOverdrawCount>b__0() { }

			internal int <CreateMaxOverdrawCount>b__1() { }

			internal void <CreateMaxOverdrawCount>b__2(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass6_0() { }

			internal int <CreatePostProcessing>b__0() { }

			internal void <CreatePostProcessing>b__1(int value) { }

			internal int <CreatePostProcessing>b__2() { }

			internal void <CreatePostProcessing>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass7_0() { }

			internal bool <CreateMSAA>b__0() { }

			internal void <CreateMSAA>b__1(bool value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass8_0() { }

			internal bool <CreateHDR>b__0() { }

			internal void <CreateHDR>b__1(bool value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass9_0() { }

			internal int <CreateTaaDebugMode>b__0() { }

			internal void <CreateTaaDebugMode>b__1(int value) { }

			internal int <CreateTaaDebugMode>b__2() { }

			internal void <CreateTaaDebugMode>b__3(int value) { }

		}


		internal static Widget CreateAdditionalWireframeShaderViews(SettingsPanel panel) { }

		internal static Widget CreateHDR(SettingsPanel panel) { }

		internal static Widget CreateMapOverlays(SettingsPanel panel) { }

		internal static Widget CreateMapOverlaySize(SettingsPanel panel) { }

		internal static Widget CreateMaxOverdrawCount(SettingsPanel panel) { }

		internal static Widget CreateMSAA(SettingsPanel panel) { }

		internal static Widget CreateOverdrawMode(SettingsPanel panel) { }

		internal static Widget CreatePixelValidationChannels(SettingsPanel panel) { }

		internal static Widget CreatePixelValidationMode(SettingsPanel panel) { }

		internal static Widget CreatePixelValueRangeMax(SettingsPanel panel) { }

		internal static Widget CreatePixelValueRangeMin(SettingsPanel panel) { }

		internal static Widget CreatePostProcessing(SettingsPanel panel) { }

		internal static Widget CreateTaaDebugMode(SettingsPanel panel) { }

		internal static Widget CreateWireframeNotSupportedWarning(SettingsPanel panel) { }

	}

	private DebugWireframeMode m_WireframeMode; //Field offset: 0x10
	private bool m_Overdraw; //Field offset: 0x14
	private DebugOverdrawMode m_OverdrawMode; //Field offset: 0x18
	[CompilerGenerated]
	private int <maxOverdrawCount>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private DebugFullScreenMode <fullScreenDebugMode>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <fullScreenDebugModeOutputSizeScreenPercent>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private DebugSceneOverrideMode <sceneOverrideMode>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private DebugMipInfoMode <mipInfoMode>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private DebugPostProcessingMode <postProcessingDebugMode>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <enableMsaa>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private bool <enableHDR>k__BackingField; //Field offset: 0x35
	[CompilerGenerated]
	private TaaDebugMode <taaDebugMode>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private DebugValidationMode <validationMode>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private PixelValidationChannels <validationChannels>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private float <validationRangeMin>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private float <validationRangeMax>k__BackingField; //Field offset: 0x48

	public override bool AreAnySettingsActive
	{
		 get { } //Length: 84
	}

	public bool enableHDR
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool enableMsaa
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public DebugFullScreenMode fullScreenDebugMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int fullScreenDebugModeOutputSizeScreenPercent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override bool IsLightingActive
	{
		 get { } //Length: 32
	}

	public override bool IsPostProcessingAllowed
	{
		 get { } //Length: 40
	}

	public int maxOverdrawCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	internal DebugMipInfoMode mipInfoMode
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	[Obsolete("overdraw has been deprecated. Use overdrawMode instead.", False)]
	public bool overdraw
	{
		 get { } //Length: 8
		 set { } //Length: 52
	}

	public DebugOverdrawMode overdrawMode
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	public DebugPostProcessingMode postProcessingDebugMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	internal DebugSceneOverrideMode sceneOverrideMode
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public TaaDebugMode taaDebugMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public PixelValidationChannels validationChannels
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public DebugValidationMode validationMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float validationRangeMax
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float validationRangeMin
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public DebugWireframeMode wireframeMode
	{
		 get { } //Length: 8
		 set { } //Length: 44
	}

	public DebugDisplaySettingsRendering() { }

	public override bool get_AreAnySettingsActive() { }

	[CompilerGenerated]
	public bool get_enableHDR() { }

	[CompilerGenerated]
	public bool get_enableMsaa() { }

	[CompilerGenerated]
	public DebugFullScreenMode get_fullScreenDebugMode() { }

	[CompilerGenerated]
	public int get_fullScreenDebugModeOutputSizeScreenPercent() { }

	public override bool get_IsLightingActive() { }

	public override bool get_IsPostProcessingAllowed() { }

	[CompilerGenerated]
	public int get_maxOverdrawCount() { }

	[CompilerGenerated]
	internal DebugMipInfoMode get_mipInfoMode() { }

	public bool get_overdraw() { }

	public DebugOverdrawMode get_overdrawMode() { }

	[CompilerGenerated]
	public DebugPostProcessingMode get_postProcessingDebugMode() { }

	[CompilerGenerated]
	internal DebugSceneOverrideMode get_sceneOverrideMode() { }

	[CompilerGenerated]
	public TaaDebugMode get_taaDebugMode() { }

	[CompilerGenerated]
	public PixelValidationChannels get_validationChannels() { }

	[CompilerGenerated]
	public DebugValidationMode get_validationMode() { }

	[CompilerGenerated]
	public float get_validationRangeMax() { }

	[CompilerGenerated]
	public float get_validationRangeMin() { }

	public DebugWireframeMode get_wireframeMode() { }

	[CompilerGenerated]
	public void set_enableHDR(bool value) { }

	[CompilerGenerated]
	public void set_enableMsaa(bool value) { }

	[CompilerGenerated]
	public void set_fullScreenDebugMode(DebugFullScreenMode value) { }

	[CompilerGenerated]
	public void set_fullScreenDebugModeOutputSizeScreenPercent(int value) { }

	[CompilerGenerated]
	public void set_maxOverdrawCount(int value) { }

	[CompilerGenerated]
	internal void set_mipInfoMode(DebugMipInfoMode value) { }

	public void set_overdraw(bool value) { }

	public void set_overdrawMode(DebugOverdrawMode value) { }

	[CompilerGenerated]
	public void set_postProcessingDebugMode(DebugPostProcessingMode value) { }

	[CompilerGenerated]
	internal void set_sceneOverrideMode(DebugSceneOverrideMode value) { }

	[CompilerGenerated]
	public void set_taaDebugMode(TaaDebugMode value) { }

	[CompilerGenerated]
	public void set_validationChannels(PixelValidationChannels value) { }

	[CompilerGenerated]
	public void set_validationMode(DebugValidationMode value) { }

	[CompilerGenerated]
	public void set_validationRangeMax(float value) { }

	[CompilerGenerated]
	public void set_validationRangeMin(float value) { }

	public void set_wireframeMode(DebugWireframeMode value) { }

	public override bool TryGetScreenClearColor(ref Color color) { }

	private override IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

	private void UpdateDebugSceneOverrideMode() { }

}

