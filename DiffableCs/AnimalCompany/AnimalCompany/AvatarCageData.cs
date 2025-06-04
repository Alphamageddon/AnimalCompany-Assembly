namespace AnimalCompany;

public class AvatarCageData : ScriptableObject
{
	public string sourceAssetPath; //Field offset: 0x18
	public Vector3[] vertices; //Field offset: 0x20

        public AvatarCageData()
        {
                // No special initialisation needed beyond the ScriptableObject
                // constructor.
        }

}

