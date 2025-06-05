namespace AnimalCompany;

public class ChickenView : MobView
{
	[SerializeField]
	private AudioSource _audioSourceRunning; //Field offset: 0x88
	[SerializeField]
	private MeshRenderer _rendererTeeth; //Field offset: 0x90

	public ChickenView() { }

	public void PlayRunningSound(bool play, float volume = 1) { }

	public void SetTeethVisible(bool visible) { }

	protected virtual void Update() { }

}

