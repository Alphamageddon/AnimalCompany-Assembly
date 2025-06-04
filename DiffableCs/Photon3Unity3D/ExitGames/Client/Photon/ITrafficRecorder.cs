namespace ExitGames.Client.Photon;

public interface ITrafficRecorder
{

	public bool Enabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_Enabled() { }

	public void Record(Byte[] inBuffer, int length, bool incoming, short peerId, IPhotonSocket connection) { }

	public void set_Enabled(bool value) { }

}

