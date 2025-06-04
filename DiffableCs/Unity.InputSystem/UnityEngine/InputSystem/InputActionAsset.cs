namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
public class InputActionAsset : ScriptableObject, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <get_bindings>d__8 : IEnumerable<InputBinding>, IEnumerable, IEnumerator<InputBinding>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private InputBinding <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x70
		public InputActionAsset <>4__this; //Field offset: 0x78
		private int <numActionMaps>5__2; //Field offset: 0x80
		private int <i>5__3; //Field offset: 0x84
		private InputBinding[] <bindings>5__4; //Field offset: 0x88
		private int <numBindings>5__5; //Field offset: 0x90
		private int <n>5__6; //Field offset: 0x94

		private override InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 16
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 100
		}

		[DebuggerHidden]
		public <get_bindings>d__8(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<InputBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>.GetEnumerator() { }

		[DebuggerHidden]
		private override InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__31 : IEnumerator<InputAction>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private InputAction <>2__current; //Field offset: 0x18
		public InputActionAsset <>4__this; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28
		private ReadOnlyArray<InputAction> <actions>5__3; //Field offset: 0x30
		private int <actionCount>5__4; //Field offset: 0x40
		private int <n>5__5; //Field offset: 0x44

		private override InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.Current
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
		public <GetEnumerator>d__31(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public struct ReadFileJson
	{
		public string name; //Field offset: 0x0
		public ReadMapJson[] maps; //Field offset: 0x8
		public SchemeJson[] controlSchemes; //Field offset: 0x10

		public void ToAsset(InputActionAsset asset) { }

	}

	public struct WriteFileJson
	{
		public string name; //Field offset: 0x0
		public WriteMapJson[] maps; //Field offset: 0x8
		public SchemeJson[] controlSchemes; //Field offset: 0x10

	}

	public const string Extension = "inputactions"; //Field offset: 0x0
	[SerializeField]
	internal InputActionMap[] m_ActionMaps; //Field offset: 0x18
	[SerializeField]
	internal InputControlScheme[] m_ControlSchemes; //Field offset: 0x20
	internal InputActionState m_SharedStateForAllMaps; //Field offset: 0x28
	internal Nullable<InputBinding> m_BindingMask; //Field offset: 0x30
	internal int m_ParameterOverridesCount; //Field offset: 0x90
	internal ParameterOverride[] m_ParameterOverrides; //Field offset: 0x98
	internal DeviceArray m_Devices; //Field offset: 0xA0

	public ReadOnlyArray<InputActionMap> actionMaps
	{
		 get { } //Length: 96
	}

	public override Nullable<InputBinding> bindingMask
	{
		 get { } //Length: 16
		 set { } //Length: 296
	}

	public override IEnumerable<InputBinding> bindings
	{
		[IteratorStateMachine(typeof(<get_bindings>d__8))]
		 get { } //Length: 112
	}

	public override ReadOnlyArray<InputControlScheme> controlSchemes
	{
		 get { } //Length: 96
	}

	public override Nullable<ReadOnlyArray`1<InputDevice>> devices
	{
		 get { } //Length: 52
		 set { } //Length: 68
	}

	public bool enabled
	{
		 get { } //Length: 404
	}

	public InputAction Item
	{
		 get { } //Length: 128
	}

	public InputActionAsset() { }

	public override bool Contains(InputAction action) { }

	public override void Disable() { }

	public override void Enable() { }

	public InputAction FindAction(Guid guid) { }

	public override InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) { }

	public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = false) { }

	public InputActionMap FindActionMap(Guid id) { }

	public override int FindBinding(InputBinding mask, out InputAction action) { }

	public Nullable<InputControlScheme> FindControlScheme(string name) { }

	public int FindControlSchemeIndex(string name) { }

	public static InputActionAsset FromJson(string json) { }

	public ReadOnlyArray<InputActionMap> get_actionMaps() { }

	public override Nullable<InputBinding> get_bindingMask() { }

	[IteratorStateMachine(typeof(<get_bindings>d__8))]
	public override IEnumerable<InputBinding> get_bindings() { }

	public override ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	public override Nullable<ReadOnlyArray`1<InputDevice>> get_devices() { }

	public bool get_enabled() { }

	public InputAction get_Item(string actionNameOrId) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__31))]
	public override IEnumerator<InputAction> GetEnumerator() { }

	public bool IsUsableWithDevice(InputDevice device) { }

	public void LoadFromJson(string json) { }

	internal void MarkAsDirty() { }

	private void OnDestroy() { }

	internal void OnSetupChanged() { }

	internal void OnWantToChangeSetup() { }

	private void ReResolveIfNecessary(bool fullResolve) { }

	internal void ResolveBindingsIfNecessary() { }

	public override void set_bindingMask(Nullable<InputBinding> value) { }

	public override void set_devices(Nullable<ReadOnlyArray`1<InputDevice>> value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public string ToJson() { }

}

