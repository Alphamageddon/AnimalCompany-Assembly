namespace Fusion.Statistics;

[AddComponentMenu("Fusion/Statistics/Network Object Statistics")]
[DisallowMultipleComponent]
[RequireComponent(typeof(NetworkObject))]
public class FusionNetworkObjectStatistics : MonoBehaviour
{
	[HideInInspector]
	public NetworkObject NetworkObject; //Field offset: 0x20

	public FusionNetworkObjectStatistics() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void ToggleMonitoring(bool value) { }

}

