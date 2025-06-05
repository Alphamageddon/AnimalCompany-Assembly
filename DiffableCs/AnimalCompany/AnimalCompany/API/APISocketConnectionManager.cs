namespace AnimalCompany.API;

public class APISocketConnectionManager : MonoBehaviour
{
	private static APISocketConnectionManager _instance; //Field offset: 0x0

	private ISocket socket
	{
		private get { } //Length: 136
	}

	public APISocketConnectionManager() { }

	private void Awake() { }

	private ISocket get_socket() { }

	private void HandleAPISocketClosed() { }

	private void HandleAPISocketConnected() { }

	private void HandleAPISocketError(Exception error) { }

	private void HandleUserLoggedInChanged(StateChangedEventArgs args) { }

	private void OnDestroy() { }

}

