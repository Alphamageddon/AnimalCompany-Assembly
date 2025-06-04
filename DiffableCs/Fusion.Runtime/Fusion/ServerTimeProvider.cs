namespace Fusion;

internal class ServerTimeProvider : ITimeProvider
{
	private ServerTimeProviderSettings _settings; //Field offset: 0x10
	private double _time; //Field offset: 0x18

	internal ServerTimeProvider() { }

	internal ServerTimeProvider(ServerTimeProviderSettings settings) { }

	private override void Fusion.ITimeProvider.Configure(SimulationRuntimeConfig src) { }

	private override void Fusion.ITimeProvider.Configure(TimeSyncConfiguration tsc) { }

	private override bool Fusion.ITimeProvider.IsRunning() { }

	private override void Fusion.ITimeProvider.Log(FusionStatisticsManager stats) { }

	private override Instant Fusion.ITimeProvider.Now() { }

	private override void Fusion.ITimeProvider.OnFeedbackReceived(TimeFeedback feedback) { }

	private override void Fusion.ITimeProvider.OnSnapshotReceived(double roundTripTime, Tick snapshot) { }

	private override void Fusion.ITimeProvider.Reset(double roundTripTime, Tick snapshot) { }

	private override void Fusion.ITimeProvider.ResetFeedback() { }

	private override void Fusion.ITimeProvider.Snap() { }

	private override void Fusion.ITimeProvider.Update(double unscaledDeltaTime) { }

	private void Reset(Tick snapshot) { }

	private void Update(double unscaledDeltaTime) { }

}

