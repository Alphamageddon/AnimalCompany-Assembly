namespace Unity.XR.CoreUtils.Capabilities;

public interface ICapabilityModifier
{

	public bool TryGetCapabilityValue(string capabilityKey, out bool capabilityValue) { }

}

