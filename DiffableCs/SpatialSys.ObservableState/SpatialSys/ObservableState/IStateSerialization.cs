namespace SpatialSys.ObservableState;

public interface IStateSerialization
{

	public Func<JSONNode, T> GetPrimitiveFromJSONConverter() { }

	public Func<JSONNode, Object> GetPrimitiveFromJSONConverter(Type type) { }

	public Func<T, JSONNode> GetPrimitiveToJSONConverter() { }

	public Func<Object, JSONNode> GetPrimitiveToJSONConverter(Type type) { }

	public bool HasSerializerForType() { }

	public T PrimitiveFromJSON(JSONNode json) { }

	public object PrimitiveFromJSON(Type type, JSONNode json) { }

	public JSONNode PrimitiveToJSON(T value) { }

	public JSONNode PrimitiveToJSON(Type type, object value) { }

	public StateSerializationPair<T> RegisterType(Func<T, JSONNode> serializer, Func<JSONNode, T> deserializer) { }

}

