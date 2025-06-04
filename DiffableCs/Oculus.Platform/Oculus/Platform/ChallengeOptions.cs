namespace Oculus.Platform;

public class ChallengeOptions
{
	private IntPtr Handle; //Field offset: 0x10

	public ChallengeOptions() { }

	protected virtual void Finalize() { }

	public static IntPtr op_Explicit(ChallengeOptions options) { }

	public void SetDescription(string value) { }

	public void SetEndDate(DateTime value) { }

	public void SetIncludeActiveChallenges(bool value) { }

	public void SetIncludeFutureChallenges(bool value) { }

	public void SetIncludePastChallenges(bool value) { }

	public void SetLeaderboardName(string value) { }

	public void SetStartDate(DateTime value) { }

	public void SetTitle(string value) { }

	public void SetViewerFilter(ChallengeViewerFilter value) { }

	public void SetVisibility(ChallengeVisibility value) { }

}

