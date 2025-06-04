namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

internal class TeleportationMonitor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Dictionary<TeleportationProvider, List`1<IXRInteractor>> <.cctor>b__16_0() { }

		internal Dictionary<LocomotionSystem, Pose> <.cctor>b__16_1() { }

	}

	private static readonly LinkedPool<Dictionary`2<TeleportationProvider, List`1<IXRInteractor>>> s_TeleportInteractorsPool; //Field offset: 0x0
	private static readonly LinkedPool<Dictionary`2<LocomotionSystem, Pose>> s_OriginPosesBeforeTeleportPool; //Field offset: 0x8
	private static TeleportationProvider[] s_TeleportationProvidersCache; //Field offset: 0x10
	[CompilerGenerated]
	private Action<Pose> teleported; //Field offset: 0x10
	private Dictionary<TeleportationProvider, List`1<IXRInteractor>> m_TeleportInteractors; //Field offset: 0x18
	private Dictionary<LocomotionSystem, Pose> m_OriginPosesBeforeTeleport; //Field offset: 0x20

	public event Action<Pose> teleported
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	private static TeleportationMonitor() { }

	public TeleportationMonitor() { }

	[CompilerGenerated]
	public void add_teleported(Action<Pose> value) { }

	public void AddInteractor(IXRInteractor interactor) { }

	private static bool FindTeleportationProviders() { }

	private void OnBeginTeleportation(LocomotionSystem locomotionSystem) { }

	private void OnEndTeleportation(LocomotionSystem locomotionSystem) { }

	[CompilerGenerated]
	public void remove_teleported(Action<Pose> value) { }

	public void RemoveInteractor(IXRInteractor interactor) { }

	private static bool TryGetOriginTransform(LocomotionProvider locomotionProvider, out Transform originTransform) { }

	private static bool TryGetOriginTransform(LocomotionSystem system, out Transform originTransform) { }

}

