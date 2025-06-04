namespace UnityEngine;

public abstract class Subsystem : ISubsystem
{

	protected Subsystem() { }

	public override void Destroy() { }

	protected abstract void OnDestroy() { }

	public abstract void Start() { }

	public abstract void Stop() { }

}

