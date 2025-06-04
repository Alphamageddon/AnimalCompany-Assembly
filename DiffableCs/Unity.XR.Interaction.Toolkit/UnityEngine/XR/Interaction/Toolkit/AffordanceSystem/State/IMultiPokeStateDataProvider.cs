namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;

public interface IMultiPokeStateDataProvider
{

	public IReadOnlyBindableVariable<PokeStateData> GetPokeStateDataForTarget(Transform target) { }

}

