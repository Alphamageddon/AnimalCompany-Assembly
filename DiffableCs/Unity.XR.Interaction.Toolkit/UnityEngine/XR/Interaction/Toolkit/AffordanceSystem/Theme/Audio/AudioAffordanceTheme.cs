namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Audio;

public class AudioAffordanceTheme
{
	[SerializeField]
	private List<AudioAffordanceThemeData> m_List; //Field offset: 0x10

	protected AudioAffordanceTheme() { }

	public AudioAffordanceThemeData GetAffordanceThemeDataForIndex(byte stateIndex) { }

	internal void ValidateTheme() { }

}

