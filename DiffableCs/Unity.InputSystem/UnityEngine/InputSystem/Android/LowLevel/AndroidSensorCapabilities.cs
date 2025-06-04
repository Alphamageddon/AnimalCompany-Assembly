namespace UnityEngine.InputSystem.Android.LowLevel;

internal struct AndroidSensorCapabilities
{
	public AndroidSensorType sensorType; //Field offset: 0x0

	public static AndroidSensorCapabilities FromJson(string json) { }

	public string ToJson() { }

	public virtual string ToString() { }

}

