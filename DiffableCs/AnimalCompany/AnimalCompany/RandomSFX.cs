namespace AnimalCompany;

[CreateAssetMenu(fileName = "RandomSFX", menuName = "RandomSFX")]
public class RandomSFX : ScriptableObject
{
	public List<AudioClip> audioClips; //Field offset: 0x18
	public float volume; //Field offset: 0x20
	public Vector2 pitchRange; //Field offset: 0x24
	public AudioRolloffMode rolloffMode; //Field offset: 0x2C
	public float falloffDistance; //Field offset: 0x30
	public Group audioGroup; //Field offset: 0x34

	public RandomSFX() { }

	public AudioClip GetRandomClip() { }

	public int GetRandomIndex() { }

	public void Play(Vector3 position, float volume, SFXPlayMode playMode = 1) { }

}

