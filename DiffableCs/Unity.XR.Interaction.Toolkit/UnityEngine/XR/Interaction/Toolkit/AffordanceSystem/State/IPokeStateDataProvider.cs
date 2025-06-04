namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;

public interface IPokeStateDataProvider
{

	public IReadOnlyBindableVariable<PokeStateData> pokeStateData
	{
		 get { } //Length: 0
	}

	public IReadOnlyBindableVariable<PokeStateData> get_pokeStateData() { }

}

