namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

public static class XRInteractableUtility
{
	public struct AllowTriggerCollidersScope : IDisposable
	{
		private bool m_Disposed; //Field offset: 0x0
		private readonly bool m_OldValue; //Field offset: 0x1

		public AllowTriggerCollidersScope(bool newAllowTriggerColliders) { }

		public override void Dispose() { }

	}

	[CompilerGenerated]
	private static bool <allowTriggerColliders>k__BackingField; //Field offset: 0x0

	private static bool allowTriggerColliders
	{
		[CompilerGenerated]
		private get { } //Length: 72
		[CompilerGenerated]
		private set { } //Length: 80
	}

	[CompilerGenerated]
	private static bool get_allowTriggerColliders() { }

	[CompilerGenerated]
	private static void set_allowTriggerColliders(bool value) { }

	public static bool TryGetClosestCollider(IXRInteractable interactable, Vector3 position, out DistanceInfo distanceInfo) { }

	public static bool TryGetClosestPointOnCollider(IXRInteractable interactable, Vector3 position, out DistanceInfo distanceInfo) { }

}

