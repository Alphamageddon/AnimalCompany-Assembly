namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

[AddComponentMenu(null)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Utilities.DisposableManagerSingleton.html")]
internal sealed class DisposableManagerSingleton : MonoBehaviour
{
	private static DisposableManagerSingleton s_DisposableManagerSingleton; //Field offset: 0x0
	private readonly HashSetList<IDisposable> m_Disposables; //Field offset: 0x20

	private static DisposableManagerSingleton instance
	{
		private get { } //Length: 4
	}

	public DisposableManagerSingleton() { }

	private void Awake() { }

	private void DisposeAll() { }

	private static DisposableManagerSingleton get_instance() { }

	private static DisposableManagerSingleton Initialize() { }

	private void OnApplicationQuit() { }

	private void OnDestroy() { }

	public static void RegisterDisposable(IDisposable disposableToRegister) { }

}

