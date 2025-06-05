namespace AnimalCompany;

public class SFXManager : SimulationBehaviour
{
	[CompilerGenerated]
	private sealed class <ReturnAudioSource>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float delay; //Field offset: 0x20
		public AudioSource a; //Field offset: 0x28

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
		public <ReturnAudioSource>d__13(int <>1__state) { }

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

	private static SFXManager _instance; //Field offset: 0x0
	private const int INITIAL_AUDIO_SOURCES = 20; //Field offset: 0x0
	public NetworkRunner runner; //Field offset: 0x48
	private Queue<AudioSource> _audioSources; //Field offset: 0x50

	public SFXManager() { }

	private void Awake() { }

	private static AudioSource CreateAudioSource() { }

	private void HandleNewRunner(NetworkRunner runner) { }

	private void OnDestroy() { }

	public static void PlaySFX(RandomSFX sfx, Vector3 position, float volume) { }

	public static void PlaySFXAsRPC(RandomSFX sfx, Vector3 position, float volume) { }

	public static void PlaySFXAsRPC(string sfxName, Vector3 position, float volume) { }

	private static void PlaySFXInternal(RandomSFX sfx, Vector3 position, float volume, AudioSource source, bool isPooled) { }

	[IteratorStateMachine(typeof(<ReturnAudioSource>d__13))]
	private static IEnumerator ReturnAudioSource(AudioSource a, float delay) { }

	[Rpc(RpcSources::All (7), RpcTargets::All (7))]
	public static void RPC_PlaySFX(NetworkRunner runner, string sfxResourceName, Vector3 position, float volume) { }

	[NetworkRpcStaticWeavedInvoker("System.Void AnimalCompany.SFXManager::RPC_PlaySFX(Fusion.NetworkRunner,System.String,UnityEngine.Vector3,System.Single)")]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlaySFX@Invoker(NetworkRunner runner, SimulationMessage* message) { }

}

