namespace Fusion;

public static class EngineProfiler
{
	public static Action<Single> RoundTripTimeCallback; //Field offset: 0x0
	public static Action<Int32> ResimulationsCallback; //Field offset: 0x8
	public static Action<Int32> WorldSnapshotSizeCallback; //Field offset: 0x10
	public static Action<Int32> InputSizeCallback; //Field offset: 0x18
	public static Action<Int32> InputQueueCallback; //Field offset: 0x20
	public static Action<Int32> RpcInCallback; //Field offset: 0x28
	public static Action<Int32> RpcOutCallback; //Field offset: 0x30
	public static Action<Single> StateRecvDeltaCallback; //Field offset: 0x38
	public static Action<Single> StateRecvDeltaDeviationCallback; //Field offset: 0x40
	public static Action<Single> InterpolationSpeedCallback; //Field offset: 0x48
	public static Action<Single> InterpolationOffsetCallback; //Field offset: 0x50
	public static Action<Single> InterpolationOffsetDeviationCallback; //Field offset: 0x58
	public static Action<Single> InputRecvDeltaCallback; //Field offset: 0x60
	public static Action<Single> SimulationSpeedCallback; //Field offset: 0x68
	public static Action<Single> InputRecvDeltaDeviationCallback; //Field offset: 0x70
	public static Action<Single> SimulationOffsetCallback; //Field offset: 0x78
	public static Action<Single> SimulationOffsetDeviationCallback; //Field offset: 0x80

	[Conditional("ENABLE_PROFILER")]
	public static void Begin(string sample) { }

	[Conditional("ENABLE_PROFILER")]
	public static void End() { }

	[Conditional("ENABLE_PROFILER")]
	public static void InputQueue(int value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void InputRecvDelta(float value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void InputRecvDeltaDeviation(float value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void InputSize(int value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void InterpolationOffset(float value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void InterpolationOffsetDeviation(float value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void InterpolationSpeed(float value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void Resimulations(int value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void RoundTripTime(float value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void RpcIn(int value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void RpcOut(int value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void SimulationOffset(float value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void SimulationOffsetDeviation(float value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void SimulationSpeed(float value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void StateRecvDelta(float value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void StateRecvDeltaDeviation(float value) { }

	[Conditional("ENABLE_PROFILER")]
	public static void WorldSnapshotSize(int value) { }

}

