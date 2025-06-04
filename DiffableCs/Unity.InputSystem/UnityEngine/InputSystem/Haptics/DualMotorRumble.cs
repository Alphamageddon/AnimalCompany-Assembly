namespace UnityEngine.InputSystem.Haptics;

internal struct DualMotorRumble
{
	[CompilerGenerated]
	private float <lowFrequencyMotorSpeed>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private float <highFrequencyMotorSpeed>k__BackingField; //Field offset: 0x4

	public private float highFrequencyMotorSpeed
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool isRumbling
	{
		 get { } //Length: 184
	}

	public private float lowFrequencyMotorSpeed
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[CompilerGenerated]
	[IsReadOnly]
	public float get_highFrequencyMotorSpeed() { }

	public bool get_isRumbling() { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_lowFrequencyMotorSpeed() { }

	public void PauseHaptics(InputDevice device) { }

	public void ResetHaptics(InputDevice device) { }

	public void ResumeHaptics(InputDevice device) { }

	[CompilerGenerated]
	private void set_highFrequencyMotorSpeed(float value) { }

	[CompilerGenerated]
	private void set_lowFrequencyMotorSpeed(float value) { }

	public void SetMotorSpeeds(InputDevice device, float lowFrequency, float highFrequency) { }

}

