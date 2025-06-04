// Batch 2
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

                var notifState = dict[id];
                notifState.id.value = id;
                notifState.code.value = (NotificationCode)_notification.Code;
                notifState.subject.value = _notification.Subject;
                notifState.content.value = _notification.Content;
                notifState.senderID.value = _notification.SenderId;
                notifState.time.value = _notification.CreateTime;
                notifState.persistent.value = _notification.Persistent;
        }

}

