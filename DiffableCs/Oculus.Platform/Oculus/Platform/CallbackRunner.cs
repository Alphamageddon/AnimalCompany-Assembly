namespace Oculus.Platform;

public class CallbackRunner : MonoBehaviour
{
	public bool IsPersistantBetweenSceneLoads; //Field offset: 0x20

	public CallbackRunner() { }

	private void Awake() { }

	private void OnApplicationQuit() { }

	private void OnDestroy() { }

	private static void ovr_UnityResetTestPlatform() { }

	private void Update() { }

}

