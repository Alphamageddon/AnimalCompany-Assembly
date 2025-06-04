namespace UnityEngine.ProBuilder;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
internal sealed class Entity : MonoBehaviour
{
	[FormerlySerializedAs("_entityType")]
	[HideInInspector]
	[SerializeField]
	private EntityType m_EntityType; //Field offset: 0x20

	public EntityType entityType
	{
		 get { } //Length: 8
	}

	public Entity() { }

	public void Awake() { }

	public EntityType get_entityType() { }

	public void SetEntity(EntityType t) { }

}

