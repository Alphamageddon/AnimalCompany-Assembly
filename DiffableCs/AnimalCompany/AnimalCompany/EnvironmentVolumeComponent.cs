namespace AnimalCompany;

[ExecuteAlways]
[RequireComponent(typeof(Collider))]
public class EnvironmentVolumeComponent : MonoBehaviour
{
	public EnvironmentVolumeProfile profile; //Field offset: 0x20
	private Collider _volumeCollider; //Field offset: 0x28

	public Collider volumeCollider
	{
		 get { } //Length: 148
	}

	public EnvironmentVolumeComponent() { }

	public Collider get_volumeCollider() { }

	private void OnTriggerEnter(Collider other) { }

}

