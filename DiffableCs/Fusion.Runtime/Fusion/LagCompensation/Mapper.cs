namespace Fusion.LagCompensation;

internal class Mapper
{
	private readonly Dictionary<HitboxRoot, Int32> _rootToNodeIndex; //Field offset: 0x10

	internal int Count
	{
		internal get { } //Length: 80
	}

	public Mapper() { }

	internal void DeRegister(HitboxRoot root) { }

	internal int get_Count() { }

	internal int GetLeafIndex(HitboxRoot root) { }

	internal void RegisterMapping(HitboxRoot root, int leafIndex) { }

	internal bool TryGetLeafIndex(HitboxRoot root, out int index) { }

}

