namespace Fusion;

public abstract class FusionMppmCommand
{

	public override bool NeedsAck
	{
		 get { } //Length: 8
	}

	public override string PersistentKey
	{
		 get { } //Length: 8
	}

	protected FusionMppmCommand() { }

	public abstract void Execute() { }

	public override bool get_NeedsAck() { }

	public override string get_PersistentKey() { }

}

