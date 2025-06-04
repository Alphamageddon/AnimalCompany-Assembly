namespace Oculus.Platform;

public static class Callback
{
	private class RequestCallback
	{
		private Callback messageCallback; //Field offset: 0x10

		public RequestCallback() { }

		public RequestCallback(Callback callback) { }

		public override void HandleMessage(Message msg) { }

	}

	private sealed class RequestCallback : RequestCallback
	{
		private Callback<T> callback; //Field offset: 0x0

		public RequestCallback`1(Callback<T> callback) { }

		public virtual void HandleMessage(Message msg) { }

	}

	private static Dictionary<UInt64, Request> requestIDsToRequests; //Field offset: 0x0
	private static Dictionary<MessageType, RequestCallback> notificationCallbacks; //Field offset: 0x8
	private static bool hasRegisteredJoinIntentNotificationHandler; //Field offset: 0x10
	private static Message latestPendingJoinIntentNotifications; //Field offset: 0x18

	private static Callback() { }

	internal static void AddRequest(Request request) { }

	private static void FlushJoinIntentNotificationQueue() { }

	internal static void HandleMessage(Message msg) { }

	internal static void OnApplicationQuit() { }

	internal static void RunCallbacks() { }

	internal static void RunLimitedCallbacks(uint limit) { }

	internal static void SetNotificationCallback(MessageType type, Callback<T> callback) { }

	internal static void SetNotificationCallback(MessageType type, Callback callback) { }

}

