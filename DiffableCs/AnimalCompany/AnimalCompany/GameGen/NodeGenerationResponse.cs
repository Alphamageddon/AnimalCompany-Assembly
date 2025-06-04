namespace AnimalCompany.GameGen;

public struct NodeGenerationResponse
{
	public bool success; //Field offset: 0x0
	public List<Socket> outerSockets; //Field offset: 0x8
	public List<Bounds> bounds; //Field offset: 0x10
	public NodeGenerationResult result; //Field offset: 0x18

}

