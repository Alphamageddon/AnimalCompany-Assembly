//Type is in global namespace

public struct PIDState
{
	public PIDSettings pidSettings; //Field offset: 0x0
	public Vector3 errorIntegration; //Field offset: 0x10
	private Vector3 lastPosition; //Field offset: 0x1C
	public Vector3 lastError; //Field offset: 0x28
	private bool derivateInitialized; //Field offset: 0x34

	public void Reset() { }

	public Vector3 UpdateCommand(Vector3 error, float dt, bool ignoreIntegration = false) { }

}

