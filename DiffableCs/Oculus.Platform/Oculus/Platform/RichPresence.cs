namespace Oculus.Platform;

public static class RichPresence
{

	public static Request Clear() { }

	public static Request<DestinationList> GetDestinations() { }

	public static Request<DestinationList> GetNextDestinationListPage(DestinationList list) { }

	public static Request Set(RichPresenceOptions richPresenceOptions) { }

}

