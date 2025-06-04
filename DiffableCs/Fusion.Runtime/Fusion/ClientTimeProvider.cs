namespace Fusion;

internal class ClientTimeProvider : ITimeProvider
{
	private ClientTimeProviderSettings _settings; //Field offset: 0x10
	private IFeedbackController _clockFeedback; //Field offset: 0x80
	private double _latestInputOffset; //Field offset: 0x88
	private double _targetInputOffset; //Field offset: 0x90
	private double _clockTimeScaleOffset; //Field offset: 0x98
	private IFeedbackController _delayFeedback; //Field offset: 0xA0
	private double _latestInputDelay; //Field offset: 0xA8
	private double _targetInputDelay; //Field offset: 0xB0
	private double _delayTimeScaleOffset; //Field offset: 0xB8
	private IFeedbackController _interpFeedback; //Field offset: 0xC0
	private double _latestInterpDelay; //Field offset: 0xC8
	private double _targetInterpDelay; //Field offset: 0xD0
	private double _interpTimeScaleOffset; //Field offset: 0xD8
	private double _inputTime; //Field offset: 0xE0
	private double _simulationTime; //Field offset: 0xE8
	private double _interpTime; //Field offset: 0xF0
	private TimeSeries _roundTripTime; //Field offset: 0xF8
	private TimeSeries _inputOffset; //Field offset: 0x100
	private TimeSeries _interpDelay; //Field offset: 0x108
	private Timer _snapshotTimer; //Field offset: 0x110
	private TimeSeries _snapshotTimeDelta; //Field offset: 0x128
	private Tick _snapshot; //Field offset: 0x130
	private Timer _clockSyncTimer; //Field offset: 0x138
	private double _lastSeenServerTime; //Field offset: 0x150
	private double _lastSeenServerTimeScale; //Field offset: 0x158
	private Timer _sampleTimer; //Field offset: 0x160
	private Timer _resetInputTimer; //Field offset: 0x178
	private Timer _resetSimulationTimer; //Field offset: 0x190
	private Timer _resetInterpTimer; //Field offset: 0x1A8
	private int _inputTimeResetCount; //Field offset: 0x1C0
	private int _simulationTimeResetCount; //Field offset: 0x1C4
	private int _interpTimeResetCount; //Field offset: 0x1C8
	private bool _inputTimeReset; //Field offset: 0x1CC
	private bool _simulationTimeReset; //Field offset: 0x1CD
	private bool _interpTimeReset; //Field offset: 0x1CE
	private readonly List<TimeProviderCallback> _resetInputTimeCallbacks; //Field offset: 0x1D0
	private readonly List<TimeProviderCallback> _resetSimulationTimeCallbacks; //Field offset: 0x1D8
	private readonly List<TimeProviderCallback> _resetInterpTimeCallbacks; //Field offset: 0x1E0
	private bool _isRunning; //Field offset: 0x1E8
	private TimeFeedback _serverFeedback; //Field offset: 0x1EC
	private RingBuffer<TimeAdjustment> _inputOffsetAdjust; //Field offset: 0x200
	private Tick _lastInputOffsetAdjustTick; //Field offset: 0x208
	private double _totalInputOffsetAdjust; //Field offset: 0x210

	internal ClientTimeProvider() { }

	internal ClientTimeProvider(ClientTimeProviderSettings settings) { }

	private void AddInputOffsetAdjustment(double amount) { }

	private void Configure(TimeSyncConfiguration tsc) { }

	private void Configure(SimulationRuntimeConfig src) { }

	private override void Fusion.ITimeProvider.Configure(TimeSyncConfiguration tsc) { }

	private override void Fusion.ITimeProvider.Configure(SimulationRuntimeConfig src) { }

	private override bool Fusion.ITimeProvider.IsRunning() { }

	private override void Fusion.ITimeProvider.Log(FusionStatisticsManager stats) { }

	private override Instant Fusion.ITimeProvider.Now() { }

	private override void Fusion.ITimeProvider.OnFeedbackReceived(TimeFeedback feedback) { }

	private override void Fusion.ITimeProvider.OnSnapshotReceived(double roundTripTime, Tick snapshot) { }

	private override void Fusion.ITimeProvider.Reset(double roundTripTime, Tick snapshot) { }

	private override void Fusion.ITimeProvider.ResetFeedback() { }

	private override void Fusion.ITimeProvider.Snap() { }

	private override void Fusion.ITimeProvider.Update(double unscaledDeltaTime) { }

	private double GetInputOffset() { }

	private double GetInputOffsetAlt() { }

	private double GetServerTime() { }

	private double GetSnapshotTime() { }

	private void Initialize() { }

	internal void OnReset(Clock clock, TimeProviderCallback callback) { }

	private void RemoveInputOffsetAdjustmentsOlderThan(Tick snapshot) { }

	private void Reset(double roundTripTime, Tick snapshot, double time, double timeScale) { }

	private void ResetInputTime() { }

	private void ResetInterpolationTime() { }

	private void ResetSimulationTime() { }

	private double RoundToNearestMultiple(double x, double round, bool minimumOne = false) { }

	private void SaveInterpDelaySample(double interpDelay) { }

	private void Snap() { }

	private void Update(double unscaledDeltaTime) { }

	private void UpdateIncomingTargets() { }

	private void UpdateOutgoingTargets() { }

	private void UpdateServerStats(double roundTripTime, double time, double timeScale) { }

	private void UpdateSnapshot(Tick snapshot) { }

}

