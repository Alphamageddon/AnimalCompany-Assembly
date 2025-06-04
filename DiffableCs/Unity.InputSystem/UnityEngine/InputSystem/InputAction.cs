namespace UnityEngine.InputSystem;

public sealed class InputAction : ICloneable, IDisposable
{
	[Flags]
	public enum ActionFlags
	{
		WantsInitialStateCheck = 1,
	}

	internal struct CallbackContext
	{
		internal InputActionState m_State; //Field offset: 0x0
		internal int m_ActionIndex; //Field offset: 0x8

		public InputAction action
		{
			 get { } //Length: 48
		}

		private int actionIndex
		{
			private get { } //Length: 8
		}

		private int bindingIndex
		{
			private get { } //Length: 52
		}

		public bool canceled
		{
			 get { } //Length: 56
		}

		public InputControl control
		{
			 get { } //Length: 68
		}

		private int controlIndex
		{
			private get { } //Length: 52
		}

		public double duration
		{
			 get { } //Length: 104
		}

		public IInputInteraction interaction
		{
			 get { } //Length: 88
		}

		private int interactionIndex
		{
			private get { } //Length: 52
		}

		public bool performed
		{
			 get { } //Length: 56
		}

		public InputActionPhase phase
		{
			 get { } //Length: 48
		}

		public bool started
		{
			 get { } //Length: 56
		}

		public double startTime
		{
			 get { } //Length: 56
		}

		public double time
		{
			 get { } //Length: 56
		}

		public int valueSizeInBytes
		{
			 get { } //Length: 80
		}

		public Type valueType
		{
			 get { } //Length: 80
		}

		public InputAction get_action() { }

		private int get_actionIndex() { }

		private int get_bindingIndex() { }

		public bool get_canceled() { }

		public InputControl get_control() { }

		private int get_controlIndex() { }

		public double get_duration() { }

		public IInputInteraction get_interaction() { }

		private int get_interactionIndex() { }

		public bool get_performed() { }

		public InputActionPhase get_phase() { }

		public bool get_started() { }

		public double get_startTime() { }

		public double get_time() { }

		public int get_valueSizeInBytes() { }

		public Type get_valueType() { }

		public void ReadValue(Void* buffer, int bufferSize) { }

		public TValue ReadValue() { }

		public bool ReadValueAsButton() { }

		public object ReadValueAsObject() { }

		public virtual string ToString() { }

	}

	[SerializeField]
	[Tooltip("Human readable name of the action. Must be unique within its action map (case is ignored). Can be changed without breaking references to the action.")]
	internal string m_Name; //Field offset: 0x10
	[SerializeField]
	[Tooltip("Determines how the action triggers.\n\nA Value action will start and perform when a control moves from its default value and then perform on every value change. It will cancel when controls go back to default value. Also, when enabled, a Value action will respond right away to a control's current value.\n\nA Button action will start when a button is pressed and perform when the press threshold (see 'Default Button Press Point' in settings) is reached. It will cancel when the button is going below the release threshold (see 'Button Release Threshold' in settings). Also, if a button is already pressed when the action is enabled, the button has to be released first.\n\nA Pass-Through action will not explicitly start and will never cancel. Instead, for every value change on any bound control, the action will perform.")]
	internal InputActionType m_Type; //Field offset: 0x18
	[FormerlySerializedAs("m_ExpectedControlLayout")]
	[SerializeField]
	[Tooltip("The type of control expected by the action (e.g. \"Button\" or \"Stick\"). This will limit the controls shown when setting up bindings in the UI and will also limit which controls can be bound interactively to the action.")]
	internal string m_ExpectedControlType; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Unique ID of the action (GUID). Used to reference the action from bindings such that actions can be renamed without breaking references.")]
	internal string m_Id; //Field offset: 0x28
	[SerializeField]
	internal string m_Processors; //Field offset: 0x30
	[SerializeField]
	internal string m_Interactions; //Field offset: 0x38
	[SerializeField]
	internal InputBinding[] m_SingletonActionBindings; //Field offset: 0x40
	[SerializeField]
	internal ActionFlags m_Flags; //Field offset: 0x48
	internal Nullable<InputBinding> m_BindingMask; //Field offset: 0x50
	internal int m_BindingsStartIndex; //Field offset: 0xB0
	internal int m_BindingsCount; //Field offset: 0xB4
	internal int m_ControlStartIndex; //Field offset: 0xB8
	internal int m_ControlCount; //Field offset: 0xBC
	internal int m_ActionIndexInState; //Field offset: 0xC0
	internal InputActionMap m_ActionMap; //Field offset: 0xC8
	internal CallbackArray<Action`1<CallbackContext>> m_OnStarted; //Field offset: 0xD0
	internal CallbackArray<Action`1<CallbackContext>> m_OnCanceled; //Field offset: 0x120
	internal CallbackArray<Action`1<CallbackContext>> m_OnPerformed; //Field offset: 0x170

	public event Action<CallbackContext> canceled
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	public event Action<CallbackContext> performed
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	public event Action<CallbackContext> started
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	public InputActionMap actionMap
	{
		 get { } //Length: 32
	}

	public InputControl activeControl
	{
		 get { } //Length: 140
	}

	public Nullable<InputBinding> bindingMask
	{
		 get { } //Length: 16
		 set { } //Length: 468
	}

	public ReadOnlyArray<InputBinding> bindings
	{
		 get { } //Length: 48
	}

	public ReadOnlyArray<InputControl> controls
	{
		 get { } //Length: 68
	}

	private TriggerState currentState
	{
		private get { } //Length: 92
	}

	public bool enabled
	{
		 get { } //Length: 72
	}

	public string expectedControlType
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Guid id
	{
		 get { } //Length: 52
	}

	internal Guid idDontGenerate
	{
		internal get { } //Length: 72
	}

	public bool inProgress
	{
		 get { } //Length: 76
	}

	public string interactions
	{
		 get { } //Length: 8
	}

	internal bool isSingletonAction
	{
		internal get { } //Length: 32
	}

	public string name
	{
		 get { } //Length: 8
	}

	public InputActionPhase phase
	{
		 get { } //Length: 64
	}

	public string processors
	{
		 get { } //Length: 8
	}

	public bool triggered
	{
		 get { } //Length: 4
	}

	public InputActionType type
	{
		 get { } //Length: 8
	}

	public bool wantsInitialStateCheck
	{
		 get { } //Length: 28
		 set { } //Length: 16
	}

	public InputAction() { }

	public InputAction(string name = null, InputActionType type = 0, string binding = null, string interactions = null, string processors = null, string expectedControlType = null) { }

	internal bool ActiveControlIsValid(InputControl control) { }

	public void add_canceled(Action<CallbackContext> value) { }

	public void add_performed(Action<CallbackContext> value) { }

	public void add_started(Action<CallbackContext> value) { }

	internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction) { }

	internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap) { }

	public InputAction Clone() { }

	private void CreateInternalActionMapForSingletonAction() { }

	public void Disable() { }

	public override void Dispose() { }

	public void Enable() { }

	internal Nullable<InputBinding> FindEffectiveBindingMask() { }

	internal void GenerateId() { }

	public InputActionMap get_actionMap() { }

	public InputControl get_activeControl() { }

	public Nullable<InputBinding> get_bindingMask() { }

	public ReadOnlyArray<InputBinding> get_bindings() { }

	public ReadOnlyArray<InputControl> get_controls() { }

	private TriggerState get_currentState() { }

	public bool get_enabled() { }

	public string get_expectedControlType() { }

	public Guid get_id() { }

	internal Guid get_idDontGenerate() { }

	public bool get_inProgress() { }

	public string get_interactions() { }

	internal bool get_isSingletonAction() { }

	public string get_name() { }

	public InputActionPhase get_phase() { }

	public string get_processors() { }

	public bool get_triggered() { }

	public InputActionType get_type() { }

	public bool get_wantsInitialStateCheck() { }

	internal InputActionMap GetOrCreateActionMap() { }

	public float GetTimeoutCompletionPercentage() { }

	public bool IsInProgress() { }

	public bool IsPressed() { }

	internal string MakeSureIdIsInPlace() { }

	public TValue ReadValue() { }

	public object ReadValueAsObject() { }

	public void remove_canceled(Action<CallbackContext> value) { }

	public void remove_performed(Action<CallbackContext> value) { }

	public void remove_started(Action<CallbackContext> value) { }

	internal void RequestInitialStateCheckOnEnabledAction() { }

	public void Reset() { }

	public void set_bindingMask(Nullable<InputBinding> value) { }

	public void set_expectedControlType(string value) { }

	public void set_wantsInitialStateCheck(bool value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public bool WasPerformedThisFrame() { }

	public bool WasPressedThisFrame() { }

	public bool WasReleasedThisFrame() { }

}

