namespace UnityEngine;

[UsedByNativeCode("SubsystemDescriptorBase")]
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public override string id
	{
		 get { } //Length: 60
	}

	protected IntegratedSubsystemDescriptor() { }

	internal abstract ISubsystem CreateImpl() { }

	public override string get_id() { }

	private override ISubsystem UnityEngine.ISubsystemDescriptor.Create() { }

}

