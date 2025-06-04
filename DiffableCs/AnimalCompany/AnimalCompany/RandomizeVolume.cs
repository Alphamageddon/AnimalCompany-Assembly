namespace AnimalCompany;

[RequireComponent(typeof(AudioSource))]
public class RandomizeVolume : MonoBehaviour, ITileRandomizer
{
	public Vector2 volume; //Field offset: 0x20

	public RandomizeVolume() { }

	public override void Render() { }

}

