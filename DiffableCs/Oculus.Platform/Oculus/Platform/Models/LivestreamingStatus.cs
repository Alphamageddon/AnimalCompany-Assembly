namespace Oculus.Platform.Models;

public class LivestreamingStatus
{
	public readonly bool CommentsVisible; //Field offset: 0x10
	public readonly bool IsPaused; //Field offset: 0x11
	public readonly bool LivestreamingEnabled; //Field offset: 0x12
	public readonly int LivestreamingType; //Field offset: 0x14
	public readonly bool MicEnabled; //Field offset: 0x18

	public LivestreamingStatus(IntPtr o) { }

}

