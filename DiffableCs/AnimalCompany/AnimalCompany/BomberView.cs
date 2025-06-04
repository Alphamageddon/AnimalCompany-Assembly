namespace AnimalCompany;

public class BomberView : MobView
{
	private static readonly int PROP_EMISSION_COLOR; //Field offset: 0x0
	private static readonly int PROP_EMISSION_FRESNEL; //Field offset: 0x4
	private static readonly Color EMISSION_COLOR; //Field offset: 0x8
	[SerializeField]
	private Renderer _renderer; //Field offset: 0xB0
	private bool _isInExplosion; //Field offset: 0xB8

	private static BomberView() { }

	public BomberView() { }

	public void SetEmission(bool emission) { }

	protected virtual void Update() { }

}

