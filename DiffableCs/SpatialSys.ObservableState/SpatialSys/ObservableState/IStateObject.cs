namespace SpatialSys.ObservableState;

public interface IStateObject
{

	public int childCount
	{
		 get { } //Length: 0
	}

	public IEnumerable<IStateObject> childStateObjects
	{
		 get { } //Length: 0
	}

	public bool disposed
	{
		 get { } //Length: 0
	}

	public bool isDerivedState
	{
		 get { } //Length: 0
	}

	public bool isIndexedCollection
	{
		 get { } //Length: 0
	}

	public bool isLeafObject
	{
		 get { } //Length: 0
	}

	public bool isSensitiveData
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public IStateObject parentStateObject
	{
		 get { } //Length: 0
	}

	public IStateRoot root
	{
		 get { } //Length: 0
	}

	public IStateSerialization serialization
	{
		 get { } //Length: 0
	}

	public bool serialize
	{
		 get { } //Length: 0
	}

	public bool stateChangedSelf
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string stateName
	{
		 get { } //Length: 0
	}

	public string stateNameFull
	{
		 get { } //Length: 0
	}

	public void ApplyOperation(IStateOperation operation) { }

	public void CopyTo(IStateObject other) { }

	public void FromJSON(JSONNode json) { }

	public int get_childCount() { }

	public IEnumerable<IStateObject> get_childStateObjects() { }

	public bool get_disposed() { }

	public bool get_isDerivedState() { }

	public bool get_isIndexedCollection() { }

	public bool get_isLeafObject() { }

	public bool get_isSensitiveData() { }

	public IStateObject get_parentStateObject() { }

	public IStateRoot get_root() { }

	public IStateSerialization get_serialization() { }

	public bool get_serialize() { }

	public bool get_stateChangedSelf() { }

	public string get_stateName() { }

	public string get_stateNameFull() { }

	public bool IsChildOf(IStateObject parent) { }

	public void Reset(bool recursively = true) { }

	public void set_isSensitiveData(bool value) { }

	public void set_stateChangedSelf(bool value) { }

	public JSONNode ToJSON(IList<IStateObject> filterStates, bool includeSyncRate = true) { }

	public JSONNode ToJSON(Predicate<IStateObject> filter = null, bool includeSyncRate = true) { }

	public bool TryFindChild(object childObjectKey, out IStateObject result) { }

	public bool TryFindChildByPath(string relativePath, out IStateObject result) { }

}

