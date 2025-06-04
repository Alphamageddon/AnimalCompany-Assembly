namespace Fusion.Addons.Physics;

[DisallowMultipleComponent]
public class RunnerSimulatePhysics2D : RunnerSimulatePhysicsBase<PhysicsScene2D>
{

	protected virtual bool AutoSyncTransforms
	{
		 get { } //Length: 80
		 set { } //Length: 88
	}

	protected virtual PhysicsTimings UnityPhysicsMode
	{
		 get { } //Length: 80
	}

	public RunnerSimulatePhysics2D() { }

	protected virtual bool get_AutoSyncTransforms() { }

	protected virtual PhysicsTimings get_UnityPhysicsMode() { }

	protected virtual void OverrideAutoSimulate(bool set) { }

	protected virtual void RestoreAutoSimulate() { }

	protected virtual void set_AutoSyncTransforms(bool value) { }

	protected virtual void SimulateAdditionalScenes(float deltaTime, bool checkPhysicsSimulation) { }

	protected virtual void SimulatePrimaryScene(float deltaTime) { }

}

