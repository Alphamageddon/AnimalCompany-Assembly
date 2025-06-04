namespace UnityEngine.XR.Management;

public sealed class XRManagerSettings : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <InitializeLoader>d__24 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public XRManagerSettings <>4__this; //Field offset: 0x20
		private Enumerator<XRLoader> <>7__wrap1; //Field offset: 0x28

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
		public <InitializeLoader>d__24(int <>1__state) { }

		private void <>m__Finally1() { }

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

	[HideInInspector]
	private bool m_InitializationComplete; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private bool m_RequiresSettingsUpdate; //Field offset: 0x19
	[FormerlySerializedAs("AutomaticLoading")]
	[SerializeField]
	[Tooltip("Determines if the XR Manager instance is responsible for creating and destroying the appropriate loader instance.")]
	private bool m_AutomaticLoading; //Field offset: 0x1A
	[FormerlySerializedAs("AutomaticRunning")]
	[SerializeField]
	[Tooltip("Determines if the XR Manager instance is responsible for starting and stopping subsystems for the active loader instance.")]
	private bool m_AutomaticRunning; //Field offset: 0x1B
	[FormerlySerializedAs("Loaders")]
	[SerializeField]
	[Tooltip("List of XR Loader instances arranged in desired load order.")]
	private List<XRLoader> m_Loaders; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private HashSet<XRLoader> m_RegisteredLoaders; //Field offset: 0x28
	[CompilerGenerated]
	private XRLoader <activeLoader>k__BackingField; //Field offset: 0x30

	[HideInInspector]
	public private XRLoader activeLoader
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public IReadOnlyList<XRLoader> activeLoaders
	{
		 get { } //Length: 8
	}

	public bool automaticLoading
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool automaticRunning
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	internal List<XRLoader> currentLoaders
	{
		internal get { } //Length: 8
		internal set { } //Length: 8
	}

	public bool isInitializationComplete
	{
		 get { } //Length: 8
	}

	[Obsolete("'XRManagerSettings.loaders' property is obsolete. Use 'XRManagerSettings.activeLoaders' instead to get a list of the current loaders.")]
	public List<XRLoader> loaders
	{
		 get { } //Length: 8
	}

	internal HashSet<XRLoader> registeredLoaders
	{
		internal get { } //Length: 8
	}

	public XRManagerSettings() { }

	public T ActiveLoaderAs() { }

	private void Awake() { }

	private bool CheckGraphicsAPICompatibility(XRLoader loader) { }

	public void DeinitializeLoader() { }

	[CompilerGenerated]
	public XRLoader get_activeLoader() { }

	public IReadOnlyList<XRLoader> get_activeLoaders() { }

	public bool get_automaticLoading() { }

	public bool get_automaticRunning() { }

	internal List<XRLoader> get_currentLoaders() { }

	public bool get_isInitializationComplete() { }

	public List<XRLoader> get_loaders() { }

	internal HashSet<XRLoader> get_registeredLoaders() { }

	[IteratorStateMachine(typeof(<InitializeLoader>d__24))]
	public IEnumerator InitializeLoader() { }

	public void InitializeLoaderSync() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	[CompilerGenerated]
	private void set_activeLoader(XRLoader value) { }

	public void set_automaticLoading(bool value) { }

	public void set_automaticRunning(bool value) { }

	internal void set_currentLoaders(List<XRLoader> value) { }

	private void Start() { }

	public void StartSubsystems() { }

	public void StopSubsystems() { }

	public bool TryAddLoader(XRLoader loader, int index = -1) { }

	public bool TryRemoveLoader(XRLoader loader) { }

	public bool TrySetLoaders(List<XRLoader> reorderedLoaders) { }

}

