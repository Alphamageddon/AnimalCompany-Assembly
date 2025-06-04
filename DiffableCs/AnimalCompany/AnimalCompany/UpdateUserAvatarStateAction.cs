// Batch 2
namespace AnimalCompany;

public class UpdateUserAvatarStateAction : BaseAction
{
        private ApiUserAvatar _avatar; //Field offset: 0x18

        public UpdateUserAvatarStateAction(ApiUserAvatar avatar)
        {
                _avatar = avatar;
        }

        public virtual void Execute(AppState state)
        {
                if (_avatar == null || state?.user == null)
                        return;

                if (state.user.avatar == null)
                        state.user.avatar = new UserAvatarState();

                state.user.avatar.FromApiModel(_avatar);
        }

}

