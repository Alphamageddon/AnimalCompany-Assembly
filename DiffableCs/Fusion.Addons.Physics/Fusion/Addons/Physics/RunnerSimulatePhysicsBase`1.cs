namespace Fusion.Addons.Physics;

public abstract class RunnerSimulatePhysicsBase : RunnerSimulatePhysicsBase
{
	internal struct AdditionalScene
	{
		public TPhysicsScene PhysicsScene; //Field offset: 0x0
		public ClientPhysicsSimulation ClientPhysicsSimulation; //Field offset: 0x0

	}

	protected List<AdditionalScene<TPhysicsScene>> _additionalScenes; //Field offset: 0x0

	protected RunnerSimulatePhysicsBase`1() { }

	protected virtual bool AnySceneRequiresSyncTransform() { }

	public void RegisterAdditionalScene(TPhysicsScene scene, ClientPhysicsSimulation clientPhysicsSimulation = 0) { }

	public void UnregisterAdditionalScene(TPhysicsScene scene) { }

}

