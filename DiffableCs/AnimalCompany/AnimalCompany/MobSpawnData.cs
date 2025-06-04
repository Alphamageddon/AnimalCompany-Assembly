namespace AnimalCompany;

[CreateAssetMenu(fileName = "MobSpawnData", menuName = "AnimalCompany/MobSpawnData", order = 1)]
public class MobSpawnData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MobData, Int32> <>9__6_0; //Field offset: 0x8
		public static Func<MobData, Int32> <>9__7_0; //Field offset: 0x10
		public static Func<MobData, Int32> <>9__7_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <GetMobsToSpawn>b__6_0(MobData mobData) { }

		internal int <GetMobsToSpawnGuaranteeEveryMonster>b__7_0(MobData mobData) { }

		internal int <GetMobsToSpawnGuaranteeEveryMonster>b__7_1(MobData mob) { }

	}

	internal class MobData
	{
		public GameObject prefab; //Field offset: 0x10
		public int weight; //Field offset: 0x18

		public MobData() { }

	}

	public int mobSpawnCount; //Field offset: 0x18
	public int landMineSpawnCount; //Field offset: 0x1C
	public MobData[] mobDatas; //Field offset: 0x20
	public GameObject landMinePrefab; //Field offset: 0x28

	public MobSpawnData() { }

	public List<GameObject> GetMobsToSpawn() { }

	public List<GameObject> GetMobsToSpawn(int count) { }

	public List<GameObject> GetMobsToSpawnGuaranteeEveryMonster(int count) { }

}

