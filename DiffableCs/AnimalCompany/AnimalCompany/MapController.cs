namespace AnimalCompany;

public class MapController : MonoBehaviour
{
	[SerializeField]
	private MapView _mapView; //Field offset: 0x20
	private float _lastPlayerUpdateTime; //Field offset: 0x28
	private float _lastScannerUpdateTime; //Field offset: 0x2C

	public MapController() { }

	private void Update() { }

}

