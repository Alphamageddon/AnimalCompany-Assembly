namespace SpatialSys.ObservableState;

public interface IDerivableState
{

	public bool isDerivedState
	{
		 get { } //Length: 0
	}

	public bool get_isDerivedState() { }

	public void RegisterDerivedState(ObserverDelegate observer, IStateObject[] state) { }

	public void RegisterDerivedStateChildren(ObserverDelegate observer, IStateObject[] state) { }

	public void RegisterDerivedStateSelf(ObserverDelegate observer, IStateObject[] state) { }

}

