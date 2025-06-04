namespace AnimalCompany;

public class AddNotificationAction : BaseAction
{
        private IApiNotification _notification; //Field offset: 0x18

        public AddNotificationAction(IApiNotification notification)
        {
                _notification = notification;
        }

        public override void Execute(AppState state)
        {
                if (_notification == null || state?.user?.notifications?.all == null)
                        return;

                var dict = state.user.notifications.all;
                string id = _notification.Id ?? System.Guid.NewGuid().ToString();

                if (!dict.ContainsKey(id))
                {
                        dict[id] = new NotificationState();
                }
        }

}

