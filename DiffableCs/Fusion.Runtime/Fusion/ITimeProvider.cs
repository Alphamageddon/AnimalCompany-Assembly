namespace Fusion;

internal interface ITimeProvider
{

	public void Configure(SimulationRuntimeConfig src) { }

	public void Configure(TimeSyncConfiguration tsc) { }

	public bool IsRunning() { }

	public void Log(FusionStatisticsManager stats) { }

	public Instant Now() { }

	public void OnFeedbackReceived(TimeFeedback feedback) { }

	public void OnSnapshotReceived(double roundTripTime, Tick snapshot) { }

	public void Reset(double roundTripTime, Tick snapshot) { }

	public void ResetFeedback() { }

	public void Snap() { }

	public void Update(double unscaledDeltaTime) { }

}

