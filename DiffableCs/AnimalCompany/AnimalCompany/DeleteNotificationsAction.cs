namespace AnimalCompany;

public class DeleteNotificationsAction : BaseAction
{
	private String[] _notificationIDs; //Field offset: 0x18

	public DeleteNotificationsAction(String[] notificationIDs) { }

	public virtual void Execute(AppState state) { }

}

