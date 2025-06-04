namespace Satori;

public interface IClient
{

	public bool AutoRefreshSession
	{
		 get { } //Length: 0
	}

	public Task<ISession> AuthenticateAsync(string id, Dictionary<String, String> defaultProperties = null, Dictionary<String, String> customProperties = null, Nullable<CancellationToken> cancellationToken = null) { }

	public Task AuthenticateLogoutAsync(ISession session, Nullable<CancellationToken> cancellationToken = null) { }

	public Task DeleteIdentityAsync(ISession session, Nullable<CancellationToken> cancellationToken = null) { }

	public Task DeleteMessageAsync(ISession session, string id, Nullable<CancellationToken> cancellationToken = null) { }

	public Task EventAsync(ISession session, Event event, Nullable<CancellationToken> cancellationToken = null) { }

	public Task EventsAsync(ISession session, IEnumerable<Event> events, Nullable<CancellationToken> cancellationToken = null) { }

	public bool get_AutoRefreshSession() { }

	public Task<IApiExperimentList> GetAllExperimentsAsync(ISession session, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<IApiExperimentList> GetExperimentsAsync(ISession session, IEnumerable<String> names, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<IApiFlag> GetFlagAsync(ISession session, string name, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<IApiFlag> GetFlagAsync(ISession session, string name, string defaultValue, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<IApiFlag> GetFlagDefaultAsync(string name, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<IApiFlag> GetFlagDefaultAsync(string name, string defaultValue, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<IApiFlagList> GetFlagsAsync(ISession session, IEnumerable<String> names, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<IApiFlagList> GetFlagsDefaultAsync(IEnumerable<String> names, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<IApiLiveEventList> GetLiveEventsAsync(ISession session, IEnumerable<String> names = null, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<IApiGetMessageListResponse> GetMessageListAsync(ISession session, int limit = 1, bool forward = true, string cursor = null, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<ISession> IdentifyAsync(ISession session, string id, Dictionary<String, String> defaultProperties, Dictionary<String, String> customProperties, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<IApiProperties> ListPropertiesAsync(ISession session, Nullable<CancellationToken> cancellationToken = null) { }

	public Task<ISession> SessionRefreshAsync(ISession session, Nullable<CancellationToken> cancellationToken = null) { }

	public Task UpdateMessageAsync(ISession session, string id, string consumeTime, string readTime, Nullable<CancellationToken> cancellationToken = null) { }

	public Task UpdatePropertiesAsync(ISession session, Dictionary<String, String> defaultProperties, Dictionary<String, String> customProperties, bool recompute, Nullable<CancellationToken> cancellationToken = null) { }

}

