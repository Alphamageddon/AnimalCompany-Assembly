namespace Oculus.Platform;

public class MessageWithPlatformInitialize : Message<PlatformInitialize>
{

	public MessageWithPlatformInitialize(IntPtr c_message) { }

	protected virtual PlatformInitialize GetDataFromMessage(IntPtr c_message) { }

	public virtual PlatformInitialize GetPlatformInitialize() { }

}

