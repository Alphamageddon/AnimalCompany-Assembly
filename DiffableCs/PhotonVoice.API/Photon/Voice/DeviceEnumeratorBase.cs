namespace Photon.Voice;

public abstract class DeviceEnumeratorBase : IDeviceEnumerator, IDisposable, IEnumerable<DeviceInfo>, IEnumerable
{
	protected List<DeviceInfo> devices; //Field offset: 0x10
	protected ILogger logger; //Field offset: 0x18
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x20
	private Action onReady; //Field offset: 0x28

	public override string Error
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override bool IsSupported
	{
		 get { } //Length: 8
	}

	public override Action OnReady
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	public DeviceEnumeratorBase(ILogger logger) { }

	public abstract void Dispose() { }

	[CompilerGenerated]
	public override string get_Error() { }

	public override bool get_IsSupported() { }

	protected Action get_OnReady() { }

	public override IEnumerator<DeviceInfo> GetEnumerator() { }

	public abstract void Refresh() { }

	[CompilerGenerated]
	protected override void set_Error(string value) { }

	public override void set_OnReady(Action value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

