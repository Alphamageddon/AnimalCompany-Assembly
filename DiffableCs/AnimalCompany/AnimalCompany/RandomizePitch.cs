namespace AnimalCompany;

[RequireComponent(typeof(AudioSource))]
public class RandomizePitch : MonoBehaviour, ITileRandomizer
{
	public Vector2 pitch; //Field offset: 0x20

	public RandomizePitch() { }

	public override void Render() { }

}

