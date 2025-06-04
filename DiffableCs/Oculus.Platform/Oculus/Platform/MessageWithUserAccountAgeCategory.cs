namespace Oculus.Platform;

public class MessageWithUserAccountAgeCategory : Message<UserAccountAgeCategory>
{

	public MessageWithUserAccountAgeCategory(IntPtr c_message) { }

	protected virtual UserAccountAgeCategory GetDataFromMessage(IntPtr c_message) { }

	public virtual UserAccountAgeCategory GetUserAccountAgeCategory() { }

}

