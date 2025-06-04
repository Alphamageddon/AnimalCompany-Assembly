namespace Fusion;

[Extension]
public static class FusionUnitySceneManagerUtils
{
	internal class SceneEqualityComparer : IEqualityComparer<Scene>
	{

		public SceneEqualityComparer() { }

		public override bool Equals(Scene x, Scene y) { }

		public override int GetHashCode(Scene obj) { }

	}

	private static readonly List<GameObject> _reusableGameObjectList; //Field offset: 0x0

	private static FusionUnitySceneManagerUtils() { }

	[Extension]
	public static bool CanBeUnloaded(Scene scene) { }

	[Extension]
	public static string Dump(Scene scene) { }

	[Extension]
	public static string Dump(LoadSceneParameters loadSceneParameters) { }

	[Extension]
	public static T FindComponent(Scene scene, bool includeInactive = false) { }

	[Extension]
	public static T[] GetComponents(Scene scene, bool includeInactive) { }

	[Extension]
	public static T[] GetComponents(Scene scene, bool includeInactive, out GameObject[] rootObjects) { }

	[Extension]
	public static void GetComponents(Scene scene, List<T> results, bool includeInactive) { }

	public static void GetFileNameWithoutExtensionPosition(string nameOrPath, out int index, out int length) { }

	[Extension]
	public static LocalPhysicsMode GetLocalPhysicsMode(Scene scene) { }

	public static int GetSceneBuildIndex(string nameOrPath) { }

	public static int GetSceneIndex(IList<String> scenePathsOrNames, string nameOrPath) { }

	[Extension]
	public static bool IsAddedToBuildSettings(Scene scene) { }

}

