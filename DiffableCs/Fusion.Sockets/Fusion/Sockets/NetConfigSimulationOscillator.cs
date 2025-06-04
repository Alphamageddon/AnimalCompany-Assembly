namespace Fusion.Sockets;

public struct NetConfigSimulationOscillator
{
	internal enum WaveShape
	{
		Noise = 0,
		Sine = 1,
		Square = 2,
		Triangle = 3,
		Saw = 4,
		ReverseSaw = 5,
	}

	public WaveShape Shape; //Field offset: 0x0
	public double Min; //Field offset: 0x8
	public double Max; //Field offset: 0x10
	public double Period; //Field offset: 0x18
	public double Threshold; //Field offset: 0x20
	public double Additional; //Field offset: 0x28

	public double GetCurveValue(Random rng, double elapsedSecs) { }

}

