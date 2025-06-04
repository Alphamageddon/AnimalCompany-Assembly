namespace Fusion;

[Flags]
internal enum AnimatorSyncSettings
{
	ParameterInts = 1,
	ParameterFloats = 2,
	ParameterBools = 4,
	ParameterTriggers = 8,
	StateRoot = 16,
	StateLayers = 32,
	LayerWeights = 64,
}

