namespace Oculus.Platform;

public class MessageWithOrgScopedID : Message<OrgScopedID>
{

	public MessageWithOrgScopedID(IntPtr c_message) { }

	protected virtual OrgScopedID GetDataFromMessage(IntPtr c_message) { }

	public virtual OrgScopedID GetOrgScopedID() { }

}

