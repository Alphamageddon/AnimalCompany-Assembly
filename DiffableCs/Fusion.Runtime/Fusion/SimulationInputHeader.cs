namespace Fusion;

public struct SimulationInputHeader
{
	public const int WORD_COUNT = 4; //Field offset: 0x0
	public const int SIZE = 16; //Field offset: 0x0
	public Tick Tick; //Field offset: 0x0
	public float InterpAlpha; //Field offset: 0x4
	public Tick InterpFrom; //Field offset: 0x8
	public Tick InterpTo; //Field offset: 0xC

}

