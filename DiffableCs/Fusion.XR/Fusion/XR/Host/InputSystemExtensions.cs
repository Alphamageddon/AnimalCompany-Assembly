namespace Fusion.XR.Host;

[Extension]
public static class InputSystemExtensions
{

	[Extension]
	public static void EnableWithDefaultXRBindings(InputActionProperty property, List<String> bindings = null, List<String> leftBindings = null, List<String> rightBindings = null) { }

	[Extension]
	public static void EnableWithDefaultXRBindings(InputActionProperty property, RigPart side, List<String> bindings) { }

}

