namespace SpatialSys.CommandLib;

public class WaitForFramesCommand : Command
{
	private int _frameCount; //Field offset: 0x38

	public WaitForFramesCommand(int frameCount) { }

	public WaitForFramesCommand(string identifier, int frameCount) { }

	public virtual string ToString() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

