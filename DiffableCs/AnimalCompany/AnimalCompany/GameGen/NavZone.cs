namespace AnimalCompany.GameGen;

public struct NavZone
{
	public int zoneID; //Field offset: 0x0
	public NavPoint[] navPoints; //Field offset: 0x8
	public NavPoint[] spawnablePoints; //Field offset: 0x10

	public NavZone(NavPoint[] points, int ID) { }

	public NavPoint GetRandomPoint() { }

	public NavPoint GetRandomSpawnablePoint() { }

}

