namespace Fusion;

internal struct InterpolationParams
{
	public double Time; //Field offset: 0x0
	public Tick From; //Field offset: 0x8
	public Tick To; //Field offset: 0xC
	public float Alpha; //Field offset: 0x10
	public Status Status; //Field offset: 0x14

}

