namespace Fusion.LagCompensation;

public class BVHNodeDrawInfo
{
	internal HitboxBuffer Buffer; //Field offset: 0x10
	internal int NodeIndex; //Field offset: 0x18

	public Bounds Bounds
	{
		 get { } //Length: 104
	}

	public int Depth
	{
		 get { } //Length: 80
	}

	public int MaxDepth
	{
		 get { } //Length: 40
	}

	internal BVHNodeDrawInfo(HitboxBuffer buffer) { }

	internal BVHNodeDrawInfo FromBVHNode(ref BVHNode node) { }

	public Bounds get_Bounds() { }

	public int get_Depth() { }

	public int get_MaxDepth() { }

}

