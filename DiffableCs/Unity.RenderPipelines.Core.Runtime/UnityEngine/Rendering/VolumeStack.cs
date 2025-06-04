namespace UnityEngine.Rendering;

public sealed class VolumeStack : IDisposable
{
	internal readonly Dictionary<Type, VolumeComponent> components; //Field offset: 0x10
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"parameter", "defaultValue"}])]
	internal ValueTuple<VolumeParameter, VolumeParameter>[] defaultParameters; //Field offset: 0x18
	internal bool requiresReset; //Field offset: 0x20

	internal VolumeStack() { }

	internal void Clear() { }

	public override void Dispose() { }

	public T GetComponent() { }

	public VolumeComponent GetComponent(Type type) { }

	internal void Reload(List<VolumeComponent> componentDefaultStates) { }

}

