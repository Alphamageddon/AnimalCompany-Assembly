namespace Fusion;

internal struct ClientTimeProviderSettings
{
	public double TimeScaleOffsetMax; //Field offset: 0x0
	public double SampleWindowSeconds; //Field offset: 0x8
	public double OutgoingLateTolerance; //Field offset: 0x10
	public double IncomingLateTolerance; //Field offset: 0x18
	public double OutgoingRedundancy; //Field offset: 0x20
	public double IncomingRedundancy; //Field offset: 0x28
	public int OutgoingSendRate; //Field offset: 0x30
	public int IncomingSendRate; //Field offset: 0x34
	public double OutgoingSendDelta; //Field offset: 0x38
	public double IncomingSendDelta; //Field offset: 0x40
	public double PredictionMax; //Field offset: 0x48
	public double InputDelayMin; //Field offset: 0x50
	public double InputDelayMax; //Field offset: 0x58
	public int SimTickRate; //Field offset: 0x60
	public double SimDeltaTime; //Field offset: 0x68

	public static ClientTimeProviderSettings Default() { }

}

