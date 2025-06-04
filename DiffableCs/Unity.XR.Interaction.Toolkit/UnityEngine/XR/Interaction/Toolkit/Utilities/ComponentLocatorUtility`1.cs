namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

internal static class ComponentLocatorUtility
{
	private static T s_ComponentCache; //Field offset: 0x0

	internal static T componentCache
	{
		internal get { } //Length: 56
	}

	private static T Find() { }

	public static T FindComponent() { }

	public static T FindOrCreateComponent() { }

	internal static T get_componentCache() { }

	public static bool TryFindComponent(out T component) { }

}

