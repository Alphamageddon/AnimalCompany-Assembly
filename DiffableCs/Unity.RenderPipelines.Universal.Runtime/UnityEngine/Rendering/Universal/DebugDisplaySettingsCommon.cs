namespace UnityEngine.Rendering.Universal;

internal class DebugDisplaySettingsCommon : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Frequently Used", order = -1)]
	private class SettingsPanel : DebugDisplaySettingsPanel
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public Foldout foldout; //Field offset: 0x10

			public <>c__DisplayClass3_0() { }

			internal void <.ctor>b__0() { }

		}

		private const string k_GoToSectionString = "Go to Section..."; //Field offset: 0x0

		public virtual Flags Flags
		{
			 get { } //Length: 8
		}

		public SettingsPanel() { }

		public virtual Flags get_Flags() { }

	}

	public static class WidgetFactory
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<Boolean> <>9__0_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal bool <CreateMissingDebugShadersWarning>b__0_0() { }

		}


		internal static Widget CreateMissingDebugShadersWarning() { }

	}


	public override bool AreAnySettingsActive
	{
		 get { } //Length: 8
	}

	public override bool IsLightingActive
	{
		 get { } //Length: 8
	}

	public override bool IsPostProcessingAllowed
	{
		 get { } //Length: 8
	}

	public DebugDisplaySettingsCommon() { }

	public override IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	public override bool get_AreAnySettingsActive() { }

	public override bool get_IsLightingActive() { }

	public override bool get_IsPostProcessingAllowed() { }

	public override bool TryGetScreenClearColor(ref Color _) { }

}

