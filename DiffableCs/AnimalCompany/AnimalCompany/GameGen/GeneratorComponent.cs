namespace AnimalCompany.GameGen;

public class GeneratorComponent : MonoBehaviour
{
	private const int MAX_ATTEMPTS = 64; //Field offset: 0x0
	[Tooltip("What id do zones generated from this component start at? It's important that there are not 2 of the same zone id's")]
	public int navZoneOffset; //Field offset: 0x20
	[SerializeField]
	public List<NavZone> navZoneOutput; //Field offset: 0x28
	public GenGraph graph; //Field offset: 0x30
	public Socket socket; //Field offset: 0x38
	public List<Bounds> bounds; //Field offset: 0x40
	public Transform itemOutput; //Field offset: 0x48
	public Transform mobOutput; //Field offset: 0x50

	public GeneratorComponent() { }

	[ContextMenu("Generate")]
	public void Generate() { }

	private void OnDisable() { }

	private void OnDrawGizmosSelected() { }

	private void OnEnable() { }

	public bool TryGenerate() { }

}

