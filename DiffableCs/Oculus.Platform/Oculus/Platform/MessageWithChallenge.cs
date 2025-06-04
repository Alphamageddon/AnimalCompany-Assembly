namespace Oculus.Platform;

public class MessageWithChallenge : Message<Challenge>
{

	public MessageWithChallenge(IntPtr c_message) { }

	public virtual Challenge GetChallenge() { }

	protected virtual Challenge GetDataFromMessage(IntPtr c_message) { }

}

