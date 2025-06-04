namespace AnimalCompany.GameGen;

public class RandomizeEnabled : MonoBehaviour, ITileRandomizer
{
	[Range(0, 1)]
	[Tooltip("1 = 100%")]
	public float chance; //Field offset: 0x20

	public RandomizeEnabled() { }

	public override void Render() { }

}

