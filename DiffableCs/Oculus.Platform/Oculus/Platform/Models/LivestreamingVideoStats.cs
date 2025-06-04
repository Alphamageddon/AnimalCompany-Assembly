namespace Oculus.Platform.Models;

public class LivestreamingVideoStats
{
	public readonly int CommentCount; //Field offset: 0x10
	public readonly int ReactionCount; //Field offset: 0x14
	public readonly string TotalViews; //Field offset: 0x18

	public LivestreamingVideoStats(IntPtr o) { }

}

