namespace Oculus.Platform;

public static class Parties
{

	public static Request<Party> GetCurrent() { }

	public static void SetPartyUpdateNotificationCallback(Callback<PartyUpdateNotification> callback) { }

}

