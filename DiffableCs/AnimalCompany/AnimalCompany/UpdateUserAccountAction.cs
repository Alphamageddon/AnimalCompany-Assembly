// Batch 2
namespace AnimalCompany;

public class UpdateUserAccountAction : BaseAction
{
        private IApiAccount _account; //Field offset: 0x18

        public UpdateUserAccountAction(IApiAccount account)
        {
                _account = account;
        }

        public virtual void Execute(AppState state)
        {
                if (_account == null || state?.user == null)
                        return;

                var user = state.user;
                user.userID.value = _account.User.Id;
                user.username.value = _account.User.Username;
                user.displayName.value = _account.User.DisplayName;
                user.profilePictureURL.value = _account.User.AvatarUrl;
                user.isDeveloper.value = _account.User.Metadata?.Contains("developer") == true;
        }

}

