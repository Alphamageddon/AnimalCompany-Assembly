namespace Oculus.Platform;

public class MessageWithMicrophoneAvailabilityState : Message<MicrophoneAvailabilityState>
{

	public MessageWithMicrophoneAvailabilityState(IntPtr c_message) { }

	protected virtual MicrophoneAvailabilityState GetDataFromMessage(IntPtr c_message) { }

	public virtual MicrophoneAvailabilityState GetMicrophoneAvailabilityState() { }

}

