namespace Photon.Voice;

internal class DeviceEnumeratorNotSupported : DeviceEnumeratorBase
{
	private string message; //Field offset: 0x30

	public virtual string Error
	{
		 get { } //Length: 8
	}

	public virtual bool IsSupported
	{
		 get { } //Length: 8
	}

	public DeviceEnumeratorNotSupported(ILogger logger, string message) { }

	public virtual void Dispose() { }

	public virtual string get_Error() { }

	public virtual bool get_IsSupported() { }

	public virtual void Refresh() { }

}

