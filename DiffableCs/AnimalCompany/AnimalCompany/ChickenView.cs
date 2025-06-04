namespace AnimalCompany;

public class ChickenView : MobView
{
	[SerializeField]
	private AudioSource _audioSourceRunning; //Field offset: 0xB0
	[SerializeField]
	private MeshRenderer _rendererTeeth; //Field offset: 0xB8
	public Transform targetPlayerTransform; //Field offset: 0xC0

	public ChickenView() { }

	public void PlayRunningSound(bool play, float volume = 1) { }

	public void SetTeethVisible(bool visible) { }

	protected virtual void Update() { }

}

