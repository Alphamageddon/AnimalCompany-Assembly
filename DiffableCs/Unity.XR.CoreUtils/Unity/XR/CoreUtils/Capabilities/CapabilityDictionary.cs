namespace Unity.XR.CoreUtils.Capabilities;

public sealed class CapabilityDictionary : SerializableDictionary<String, Boolean>
{

	public CapabilityDictionary() { }

	public void ForceSerialize() { }

	public virtual void OnBeforeSerialize() { }

}

