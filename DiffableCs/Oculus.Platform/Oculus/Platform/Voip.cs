namespace Oculus.Platform;

public static class Voip
{

	public static void Accept(ulong userID) { }

	public static VoipDtxState GetIsConnectionUsingDtx(ulong peerID) { }

	public static VoipBitrate GetLocalBitrate(ulong peerID) { }

	public static Request<MicrophoneAvailabilityState> GetMicrophoneAvailability() { }

	public static VoipBitrate GetRemoteBitrate(ulong peerID) { }

	public static VoipMuteState GetSystemVoipMicrophoneMuted() { }

	public static SystemVoipStatus GetSystemVoipStatus() { }

	public static void SetMicrophoneAvailabilityStateUpdateNotificationCallback(Callback<String> callback) { }

	public static void SetMicrophoneFilterCallback(FilterCallback callback) { }

	public static void SetMicrophoneMuted(VoipMuteState state) { }

	public static void SetNewConnectionOptions(VoipOptions voipOptions) { }

	public static void SetSystemVoipStateNotificationCallback(Callback<SystemVoipState> callback) { }

	public static Request<SystemVoipState> SetSystemVoipSuppressed(bool suppressed) { }

	public static void Start(ulong userID) { }

	public static void Stop(ulong userID) { }

}

