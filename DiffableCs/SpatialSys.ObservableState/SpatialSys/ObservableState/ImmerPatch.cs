namespace SpatialSys.ObservableState;

public class ImmerPatch
{
	public JSONObject patchJSON; //Field offset: 0x10
	public IStateObject newStateObject; //Field offset: 0x18

	public ImmerPatch(JSONObject patchJSON, IStateObject newStateObject) { }

}

