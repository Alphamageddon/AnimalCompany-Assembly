namespace UnityEngine.InputSystem.Android.LowLevel;

internal struct AndroidSensorState : IInputStateTypeInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <data>e__FixedBuffer
	{
		public float FixedElementField; //Field offset: 0x0

	}

	public static FourCC kFormat; //Field offset: 0x0
	[FixedBuffer(typeof(float, 16)]
	[InputControl(name = "rotation", layout = "Quaternion", processors = "AndroidCompensateRotation", variants = "GeomagneticRotationVector")]
	[InputControl(name = "atmosphericPressure", layout = "Axis", variants = "Pressure")]
	[InputControl(name = "lightLevel", layout = "Axis", variants = "Light")]
	[InputControl(name = "angularVelocity", layout = "Vector3", processors = "CompensateDirection", variants = "Gyroscope")]
	[InputControl(name = "acceleration", layout = "Vector3", processors = "AndroidCompensateDirection", variants = "Accelerometer")]
	[InputControl(name = "magneticField", layout = "Vector3", variants = "MagneticField")]
	[InputControl(name = "distance", layout = "Axis", variants = "Proximity")]
	[InputControl(name = "gravity", layout = "Vector3", processors = "AndroidCompensateDirection", variants = "Gravity")]
	[InputControl(name = "acceleration", layout = "Vector3", processors = "AndroidCompensateDirection", variants = "LinearAcceleration")]
	[InputControl(name = "attitude", layout = "Quaternion", processors = "AndroidCompensateRotation", variants = "RotationVector")]
	[InputControl(name = "relativeHumidity", layout = "Axis", variants = "RelativeHumidity")]
	[InputControl(name = "rate", layout = "Axis", variants = "HeartRate")]
	[InputControl(name = "ambientTemperature", layout = "Axis", variants = "AmbientTemperature")]
	[InputControl(name = "stepCounter", layout = "Integer", variants = "StepCounter")]
	public <data>e__FixedBuffer data; //Field offset: 0x0

	public override FourCC format
	{
		 get { } //Length: 88
	}

	private static AndroidSensorState() { }

	public override FourCC get_format() { }

	public AndroidSensorState WithData(Single[] data) { }

}

