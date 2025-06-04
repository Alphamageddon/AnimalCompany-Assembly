namespace UnityEngine.XR.Interaction.Toolkit;

public class LocomotionVignetteProvider : ITunnelingVignetteProvider
{
	[SerializeField]
	private LocomotionProvider m_LocomotionProvider; //Field offset: 0x10
	[SerializeField]
	private bool m_Enabled; //Field offset: 0x18
	[SerializeField]
	private bool m_OverrideDefaultParameters; //Field offset: 0x19
	[SerializeField]
	private VignetteParameters m_OverrideParameters; //Field offset: 0x20

	public bool enabled
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public LocomotionProvider locomotionProvider
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool overrideDefaultParameters
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public VignetteParameters overrideParameters
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override VignetteParameters vignetteParameters
	{
		 get { } //Length: 24
	}

	public LocomotionVignetteProvider() { }

	public bool get_enabled() { }

	public LocomotionProvider get_locomotionProvider() { }

	public bool get_overrideDefaultParameters() { }

	public VignetteParameters get_overrideParameters() { }

	public override VignetteParameters get_vignetteParameters() { }

	public void set_enabled(bool value) { }

	public void set_locomotionProvider(LocomotionProvider value) { }

	public void set_overrideDefaultParameters(bool value) { }

	public void set_overrideParameters(VignetteParameters value) { }

}

