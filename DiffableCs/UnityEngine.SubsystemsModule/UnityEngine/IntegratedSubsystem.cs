namespace UnityEngine;

[NativeHeader("Modules/Subsystems/Subsystem.h")]
[UsedByNativeCode]
public class IntegratedSubsystem : ISubsystem
{
	internal IntPtr m_Ptr; //Field offset: 0x10
	internal ISubsystemDescriptor m_SubsystemDescriptor; //Field offset: 0x18

	public override bool running
	{
		 get { } //Length: 96
	}

	internal bool valid
	{
		internal get { } //Length: 16
	}

	public IntegratedSubsystem() { }

	public override void Destroy() { }

	public override bool get_running() { }

	internal bool get_valid() { }

	internal bool IsRunning() { }

	internal void SetHandle(IntegratedSubsystem subsystem) { }

	public override void Start() { }

	public override void Stop() { }

}

