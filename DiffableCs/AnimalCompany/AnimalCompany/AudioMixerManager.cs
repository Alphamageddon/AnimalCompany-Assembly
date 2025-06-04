namespace AnimalCompany;

public class AudioMixerManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <PlayerStunCoroutine>d__39 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <PlayerStunCoroutine>d__39(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum Group
	{
		Gameplay = 0,
		SFX = 1,
		Monster = 2,
		Ambience = 3,
	}

	private const string AUDIO_GROUP_NAME_GAMEPLAY = "Gameplay"; //Field offset: 0x0
	private const float LOW_PASS_FREQUENCY_HIGH = 22000; //Field offset: 0x0
	private const float LOW_PASS_FREQUENCY_LOW = 200; //Field offset: 0x0
	private const string PARAM_GAMEPLAY_PITCH = "gamePlayPitch"; //Field offset: 0x0
	private const string PARAM_GAMEPLAY_LOW_PASS = "gamePlayLowpassCutoff"; //Field offset: 0x0
	private const string AUDIO_GROUP_NAME_AMBIENCE = "Ambience"; //Field offset: 0x0
	private const string AUDIO_GROUP_NAME_MONSTER = "Monster"; //Field offset: 0x0
	private const string AUDIO_GROUP_NAME_SFX = "SFX"; //Field offset: 0x0
	private static AudioMixerGroup _audioGroupGameplay; //Field offset: 0x0
	private static AudioMixerGroup _audioGroupSFX; //Field offset: 0x8
	private static AudioMixerGroup _audioGroupMonster; //Field offset: 0x10
	private static AudioMixerGroup _audioGroupAmbience; //Field offset: 0x18
	private static AudioMixerManager _instance; //Field offset: 0x20
	private static float _stunTimer; //Field offset: 0x28
	private static IEnumerator _playerStunCoroutine; //Field offset: 0x30
	[Header("Audio Mixer")]
	[SerializeField]
	private AudioMixer _audioMixerAC; //Field offset: 0x20
	[SerializeField]
	private AudioMixer _audioMixerGameplay; //Field offset: 0x28
	[Header("Controls")]
	[Range(0, 3)]
	[SerializeField]
	private float _gameplayPitch; //Field offset: 0x30
	[Range(0, 1)]
	[SerializeField]
	private float _gameplayLowPass; //Field offset: 0x34

	public static AudioMixerGroup audioGroupAmbience
	{
		 get { } //Length: 160
	}

	public static AudioMixerGroup audioGroupGameplay
	{
		 get { } //Length: 160
	}

	public static AudioMixerGroup audioGroupMonster
	{
		 get { } //Length: 160
	}

	public static AudioMixerGroup audioGroupSFX
	{
		 get { } //Length: 160
	}

	public static float gamePlayLowPass
	{
		 get { } //Length: 84
		 set { } //Length: 100
	}

	public static float gamePlayPitch
	{
		 get { } //Length: 84
		 set { } //Length: 100
	}

	public AudioMixerManager() { }

	private void Awake() { }

	public static AudioMixerGroup get_audioGroupAmbience() { }

	public static AudioMixerGroup get_audioGroupGameplay() { }

	public static AudioMixerGroup get_audioGroupMonster() { }

	public static AudioMixerGroup get_audioGroupSFX() { }

	public static float get_gamePlayLowPass() { }

	public static float get_gamePlayPitch() { }

	public static AudioMixerGroup GetAudioGroup(Group group) { }

	private void OnDestroy() { }

	public static void PlayerStun(float duration) { }

	[IteratorStateMachine(typeof(<PlayerStunCoroutine>d__39))]
	private static IEnumerator PlayerStunCoroutine() { }

	public static void ResetSettings() { }

	public static void set_gamePlayLowPass(float value) { }

	public static void set_gamePlayPitch(float value) { }

	private static void SetGameplayLowPass(float value) { }

	private static void SetGameplayPitch(float value) { }

}

