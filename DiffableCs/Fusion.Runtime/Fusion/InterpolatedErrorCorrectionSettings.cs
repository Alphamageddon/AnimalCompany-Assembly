namespace Fusion;

public class InterpolatedErrorCorrectionSettings
{
	[InlineHelp]
	public float MinRate; //Field offset: 0x10
	[InlineHelp]
	public float MaxRate; //Field offset: 0x14
	[Header("Position Error")]
	[InlineHelp]
	public float PosBlendStart; //Field offset: 0x18
	[InlineHelp]
	public float PosBlendEnd; //Field offset: 0x1C
	[InlineHelp]
	public float PosMinCorrection; //Field offset: 0x20
	[InlineHelp]
	public float PosTeleportDistance; //Field offset: 0x24
	[Header("Rotation Error")]
	[InlineHelp]
	public float RotBlendStart; //Field offset: 0x28
	[InlineHelp]
	public float RotBlendEnd; //Field offset: 0x2C
	[InlineHelp]
	public float RotTeleportRadians; //Field offset: 0x30

	public InterpolatedErrorCorrectionSettings() { }

}

