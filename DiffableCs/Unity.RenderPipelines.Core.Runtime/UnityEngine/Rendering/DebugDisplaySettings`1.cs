namespace UnityEngine.Rendering;

public abstract class DebugDisplaySettings : IDebugDisplaySettings, IDebugDisplaySettingsQuery
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal T <.cctor>b__15_0() { }

	}

	private static readonly Lazy<T> s_Instance; //Field offset: 0x0
	protected readonly HashSet<IDebugDisplaySettingsData> m_Settings; //Field offset: 0x0

	public override bool AreAnySettingsActive
	{
		 get { } //Length: 460
	}

	public static T Instance
	{
		 get { } //Length: 152
	}

	public override bool IsLightingActive
	{
		 get { } //Length: 448
	}

	public override bool IsPostProcessingAllowed
	{
		 get { } //Length: 448
	}

	private static DebugDisplaySettings`1() { }

	protected DebugDisplaySettings`1() { }

	protected TData Add(TData newData) { }

	public override void ForEach(Action<IDebugDisplaySettingsData> onExecute) { }

	public override bool get_AreAnySettingsActive() { }

	public static T get_Instance() { }

	public override bool get_IsLightingActive() { }

	public override bool get_IsPostProcessingAllowed() { }

	public override void Reset() { }

	public override bool TryGetScreenClearColor(ref Color color) { }

}

