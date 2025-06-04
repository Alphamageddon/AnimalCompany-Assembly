namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver;

public interface IAffordanceStateReceiver : IAffordanceStateReceiver
{

	public BaseAffordanceTheme<T> affordanceTheme
	{
		 get { } //Length: 0
	}

	public IReadOnlyBindableVariable<T> currentAffordanceValue
	{
		 get { } //Length: 0
	}

	public BaseAffordanceTheme<T> get_affordanceTheme() { }

	public IReadOnlyBindableVariable<T> get_currentAffordanceValue() { }

}

