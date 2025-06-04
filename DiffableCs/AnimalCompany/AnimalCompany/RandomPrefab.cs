namespace AnimalCompany;

[CreateAssetMenu(fileName = "RandomPrefab", menuName = "RandomPrefab")]
public class RandomPrefab : ScriptableObject
{
	public GameObject[] prefabs; //Field offset: 0x18

	public GameObject prefab
	{
		 get { } //Length: 92
	}

	public RandomPrefab() { }

	public GameObject get_prefab() { }

}

