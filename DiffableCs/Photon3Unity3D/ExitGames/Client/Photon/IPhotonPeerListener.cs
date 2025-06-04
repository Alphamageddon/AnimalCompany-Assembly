namespace ExitGames.Client.Photon;

public interface IPhotonPeerListener
{

	public void DebugReturn(DebugLevel level, string message) { }

	public void OnEvent(EventData eventData) { }

	public void OnOperationResponse(OperationResponse operationResponse) { }

	public void OnStatusChanged(StatusCode statusCode) { }

}

