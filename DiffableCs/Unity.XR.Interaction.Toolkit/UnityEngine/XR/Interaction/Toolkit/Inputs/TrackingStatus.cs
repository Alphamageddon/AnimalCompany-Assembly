namespace UnityEngine.XR.Interaction.Toolkit.Inputs;

public struct TrackingStatus
{
	[CompilerGenerated]
	private bool <isConnected>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <isTracked>k__BackingField; //Field offset: 0x1
	[CompilerGenerated]
	private InputTrackingState <trackingState>k__BackingField; //Field offset: 0x4

	public bool isConnected
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool isTracked
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public InputTrackingState trackingState
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_isConnected() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_isTracked() { }

	[CompilerGenerated]
	[IsReadOnly]
	public InputTrackingState get_trackingState() { }

	[CompilerGenerated]
	public void set_isConnected(bool value) { }

	[CompilerGenerated]
	public void set_isTracked(bool value) { }

	[CompilerGenerated]
	public void set_trackingState(InputTrackingState value) { }

}

