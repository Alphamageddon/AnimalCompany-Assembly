namespace Fusion;

internal static class CallbackInterfaceInvoker
{

	public static void IAfterAllTicks(SimulationBehaviourUpdater updater, bool resimulation, int tickCount) { }

	public static void IAfterClientPredictionReset(SimulationBehaviourUpdater updater) { }

	public static void IAfterHostMigration(SimulationBehaviourUpdater updater) { }

	public static void IAfterRender(SimulationBehaviourUpdater updater) { }

	public static void IAfterTick(SimulationBehaviourUpdater updater) { }

	public static void IAfterUpdate(SimulationBehaviourUpdater updater) { }

	public static void IAfterUpdateRemotePrefabs(SimulationBehaviourUpdater updater) { }

	public static void IBeforeAllTicks(SimulationBehaviourUpdater updater, bool resimulation, int tickCount) { }

	public static void IBeforeClientPredictionReset(SimulationBehaviourUpdater updater) { }

	public static void IBeforeCopyPreviousState(SimulationBehaviourUpdater updater) { }

	public static void IBeforeHitboxRegistration(SimulationBehaviourUpdater updater) { }

	public static void IBeforeSimulation(SimulationBehaviourUpdater updater, int forwardTickCount) { }

	public static void IBeforeTick(SimulationBehaviourUpdater updater) { }

	public static void IBeforeUpdate(SimulationBehaviourUpdater updater) { }

	public static void IBeforeUpdateRemotePrefabs(SimulationBehaviourUpdater updater) { }

	public static void IPlayerJoined(SimulationBehaviourUpdater updater, PlayerRef player) { }

	public static void IPlayerLeft(SimulationBehaviourUpdater updater, PlayerRef player) { }

	public static void ISceneLoadDone(SimulationBehaviourUpdater updater, in SceneLoadDoneArgs sceneLoadDoneArgs) { }

	public static void ISceneLoadStart(SimulationBehaviourUpdater updater, SceneRef sceneRef) { }

}

