namespace AnimalCompany;

public class UpdateNotificationsAction : BaseAction
{
	private IEnumerable<IApiNotification> _notifications; //Field offset: 0x18

	public UpdateNotificationsAction(IEnumerable<IApiNotification> notifications) { }

	public virtual void Execute(AppState state) { }

}

