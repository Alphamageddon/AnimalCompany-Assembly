namespace AnimalCompany;

[RequireComponent(typeof(AudioSource))]
public class RandomizeAudioClip : MonoBehaviour, ITileRandomizer
{
	[HideArrayElementLabel]
	public AudioClip[] clips; //Field offset: 0x20

	public RandomizeAudioClip() { }

	public override void Render() { }

}

