namespace Fusion;

internal class PeerPing
{
	public const float PING_DELAY = 0.1; //Field offset: 0x0
	public int AttemptCount; //Field offset: 0x10
	public float NextAttemptCountDown; //Field offset: 0x14
	public ReflexiveInfo ReflexiveInfo; //Field offset: 0x18

	public PeerPing(ReflexiveInfo reflexiveInfo) { }

	public virtual string ToString() { }

}

