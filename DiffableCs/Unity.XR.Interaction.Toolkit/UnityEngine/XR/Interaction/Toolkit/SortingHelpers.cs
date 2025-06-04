namespace UnityEngine.XR.Interaction.Toolkit;

internal static class SortingHelpers
{
	private static readonly Dictionary<IXRInteractable, Single> s_InteractableDistanceSqrMap; //Field offset: 0x0
	private static readonly Comparison<IXRInteractable> s_InteractableDistanceComparison; //Field offset: 0x8

	private static SortingHelpers() { }

	private static int InteractableDistanceComparison(IXRInteractable x, IXRInteractable y) { }

	public static void Sort(IList<T> hits, IComparer<T> comparer) { }

	public static void Sort(IList<T> hits, IComparer<T> comparer, int count) { }

	public static void SortByDistanceToInteractor(IXRInteractor interactor, List<IXRInteractable> unsortedTargets, List<IXRInteractable> results) { }

}

