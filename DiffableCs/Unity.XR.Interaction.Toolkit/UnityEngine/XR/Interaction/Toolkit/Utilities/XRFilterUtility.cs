namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

internal static class XRFilterUtility
{

	public static bool Process(SmallRegistrationList<IXRHoverFilter> filters, IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

	public static bool Process(SmallRegistrationList<IXRSelectFilter> filters, IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	public static float Process(SmallRegistrationList<IXRInteractionStrengthFilter> filters, IXRInteractor interactor, IXRInteractable interactable, float interactionStrength) { }

}

