namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public class PokeThresholdData
{
	[SerializeField]
	[Tooltip("The axis along which the poke interaction will be constrained.")]
	private PokeAxis m_PokeDirection; //Field offset: 0x10
	[SerializeField]
	[Tooltip("Distance along the poke interactable interaction axis that allows for a poke to be triggered sooner/with less precision.")]
	private float m_InteractionDepthOffset; //Field offset: 0x14
	[SerializeField]
	[Tooltip("When enabled, the filter will check that a poke action is started and moves within the poke angle threshold along the poke direction axis.")]
	private bool m_EnablePokeAngleThreshold; //Field offset: 0x18
	[Range(0, 89.9)]
	[SerializeField]
	[Tooltip("The maximum allowed angle (in degrees) from the poke direction axis that will trigger a select interaction.")]
	private float m_PokeAngleThreshold; //Field offset: 0x1C

	public bool enablePokeAngleThreshold
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float interactionDepthOffset
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float pokeAngleThreshold
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public PokeAxis pokeDirection
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public PokeThresholdData() { }

	public bool get_enablePokeAngleThreshold() { }

	public float get_interactionDepthOffset() { }

	public float get_pokeAngleThreshold() { }

	public PokeAxis get_pokeDirection() { }

	public float GetSelectEntranceVectorDotThreshold() { }

	public void set_enablePokeAngleThreshold(bool value) { }

	public void set_interactionDepthOffset(float value) { }

	public void set_pokeAngleThreshold(float value) { }

	public void set_pokeDirection(PokeAxis value) { }

}

