namespace SpatialSys.CommandLib;

public class WaitForSecondsCommand : Command
{
	private float _durationSec; //Field offset: 0x38
	private float _elapsedTime; //Field offset: 0x3C

	public WaitForSecondsCommand(float durationSec) { }

	public WaitForSecondsCommand(string identifier, float durationSec) { }

	public virtual string ToString() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

