// Batch 2
namespace AnimalCompany;

public class UpdateUserAvatarsAction : BaseAction
{
        private GetAvatarsResponse _response; //Field offset: 0x18

        public UpdateUserAvatarsAction(GetAvatarsResponse response)
        {
                _response = response;
        }

        public virtual void Execute(AppState state)
        {
                if (_response == null || state?.userAvatars == null)
                        return;

                var dict = state.userAvatars;
                dict.Clear();
                foreach (var avatar in _response.Avatars)
                {
                        var s = new UserAvatarState();
                        s.FromApiModel(avatar);
                        dict[s.id.value] = s;
                }
        }

}

