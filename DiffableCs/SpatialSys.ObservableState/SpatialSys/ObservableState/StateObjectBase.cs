namespace SpatialSys.ObservableState;

public abstract class StateObjectBase : IStateObject
{
	private static Char[] PATH_SPLIT_SEPARATOR; //Field offset: 0x0
	private static readonly Stack<IStateObject> _jsonStateStack; //Field offset: 0x8
	[CompilerGenerated]
	private string <stateName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <stateNameFull>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <stateChangedSelf>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private IStateObject <parentStateObject>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private IStateRoot <root>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <disposed>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <serialize>k__BackingField; //Field offset: 0x39
	private bool _isSensitiveData; //Field offset: 0x3A

	public abstract int childCount
	{
		 get { } //Length: 0
	}

	public abstract IEnumerable<IStateObject> childStateObjects
	{
		 get { } //Length: 0
	}

	public private override bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public abstract bool isDerivedState
	{
		 get { } //Length: 0
	}

	public abstract bool isIndexedCollection
	{
		 get { } //Length: 0
	}

	public abstract bool isLeafObject
	{
		 get { } //Length: 0
	}

	public override bool isSensitiveData
	{
		 get { } //Length: 188
		 set { } //Length: 12
	}

	public private override IStateObject parentStateObject
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override IStateRoot root
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IStateSerialization serialization
	{
		 get { } //Length: 176
	}

	public private override bool serialize
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public override bool stateChangedSelf
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public private override string stateName
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override string stateNameFull
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static StateObjectBase() { }

	protected StateObjectBase(IStateObject parent, string stateName) { }

	protected StateObjectBase() { }

	public abstract void ApplyOperation(IStateOperation operation) { }

	public abstract void CopyTo(IStateObject other) { }

	private IStateObject FindChild(IStateObject stateObject, string stateName) { }

	public abstract void FromJSON(JSONNode json) { }

	public abstract int get_childCount() { }

	public abstract IEnumerable<IStateObject> get_childStateObjects() { }

	[CompilerGenerated]
	public override bool get_disposed() { }

	public abstract bool get_isDerivedState() { }

	public abstract bool get_isIndexedCollection() { }

	public abstract bool get_isLeafObject() { }

	public override bool get_isSensitiveData() { }

	[CompilerGenerated]
	public override IStateObject get_parentStateObject() { }

	[CompilerGenerated]
	public override IStateRoot get_root() { }

	public override IStateSerialization get_serialization() { }

	[CompilerGenerated]
	public override bool get_serialize() { }

	[CompilerGenerated]
	public override bool get_stateChangedSelf() { }

	[CompilerGenerated]
	public override string get_stateName() { }

	[CompilerGenerated]
	public override string get_stateNameFull() { }

	public bool HasStateChangedDownstream() { }

	public bool HasStateChangedUpstream() { }

	public override void InternalDispose() { }

	internal override void InternalInitialize(IStateObject parent, string stateName, bool serialize) { }

	internal override void InternalPostInitialize() { }

	public override bool IsChildOf(IStateObject parent) { }

	protected override void PostInitialize() { }

	public abstract void Reset(bool recursively = true) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	public override void set_isSensitiveData(bool value) { }

	[CompilerGenerated]
	private void set_parentStateObject(IStateObject value) { }

	[CompilerGenerated]
	protected void set_root(IStateRoot value) { }

	[CompilerGenerated]
	private void set_serialize(bool value) { }

	[CompilerGenerated]
	public override void set_stateChangedSelf(bool value) { }

	[CompilerGenerated]
	private void set_stateName(string value) { }

	[CompilerGenerated]
	private void set_stateNameFull(string value) { }

	public abstract JSONNode ToJSON(Predicate<IStateObject> filter = null, bool includeSyncRate = true) { }

	public override JSONNode ToJSON(IList<IStateObject> filterStates, bool includeSyncRate = true) { }

	public abstract bool TryFindChild(object childObjectKey, out IStateObject result) { }

	public override bool TryFindChildByPath(string relativePath, out IStateObject result) { }

}

