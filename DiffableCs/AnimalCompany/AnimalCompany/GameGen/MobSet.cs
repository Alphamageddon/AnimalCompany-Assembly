namespace AnimalCompany.GameGen;

[CreateAssetMenu(fileName = "MobSet", menuName = "GameGen/Mob Set", order = 0)]
public class MobSet : ScriptableObject
{
	public List<GameObject> mobs; //Field offset: 0x18

	public MobSet() { }

	public GameObject GetRandomMob() { }

}

