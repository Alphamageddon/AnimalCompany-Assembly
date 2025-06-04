namespace UnityEngine.InputSystem.Android.LowLevel;

[DesignTimeVisible(False)]
internal class AndroidCompensateDirectionProcessor : CompensateDirectionProcessor
{
	private const float kSensorStandardGravity = 9.80665; //Field offset: 0x0
	private const float kAccelerationMultiplier = -0.10197162; //Field offset: 0x0

	public AndroidCompensateDirectionProcessor() { }

	public virtual Vector3 Process(Vector3 vector, InputControl control) { }

}

