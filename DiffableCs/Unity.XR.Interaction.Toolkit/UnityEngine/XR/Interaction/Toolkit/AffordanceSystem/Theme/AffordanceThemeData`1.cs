namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme;

public sealed class AffordanceThemeData
{
	[Tooltip("Name of the affordance state the theme data is for.\nThis value is optional and does not serve a functional purpose.")]
	public string stateName; //Field offset: 0x0
	[Tooltip("Target value for the curve at 0")]
	public T animationStateStartValue; //Field offset: 0x0
	[Tooltip("Target value for the curve at 1.")]
	public T animationStateEndValue; //Field offset: 0x0

	public AffordanceThemeData`1() { }

}

