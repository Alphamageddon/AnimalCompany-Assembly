namespace AnimalCompany;

[RequireComponent(typeof(GrabbableItem))]
public class SFXItem : MonoBehaviour
{
	[SerializeField]
	private RandomSFX _sfx; //Field offset: 0x20
	private GrabbableItem _grabbable; //Field offset: 0x28
	private float _lastUseTime; //Field offset: 0x30

	public SFXItem() { }

	private void Awake() { }

	private void HandleUse() { }

	private void OnDestroy() { }

}

