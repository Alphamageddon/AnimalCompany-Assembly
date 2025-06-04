namespace Photon.Voice;

public interface IDeviceEnumerator : IDisposable, IEnumerable<DeviceInfo>, IEnumerable
{

	public string Error
	{
		 get { } //Length: 0
	}

	public bool IsSupported
	{
		 get { } //Length: 0
	}

	public Action OnReady
	{
		 set { } //Length: 0
	}

	public string get_Error() { }

	public bool get_IsSupported() { }

	public void Refresh() { }

	public void set_OnReady(Action value) { }

}

