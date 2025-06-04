namespace AnimalCompany;

public class AddFriendAction : BaseAction
{
        private IApiUser _user; //Field offset: 0x18
        private UserCacheState _userCacheState; //Field offset: 0x20
        private FriendshipState _friendshipState; //Field offset: 0x28

        public AddFriendAction(IApiUser user, FriendshipState friendshipState)
        {
                _user = user;
                _friendshipState = friendshipState;
        }

        public AddFriendAction(UserCacheState userCacheState, FriendshipState friendshipState)
        {
                _userCacheState = userCacheState;
                _friendshipState = friendshipState;
        }

        public override void Execute(AppState state)
        {
                if (state == null)
                        return;

                // If we were provided a cached user reference use that,
                // otherwise try to find/create one from the IApiUser data.
                var cache = _userCacheState;

                if (cache == null && _user != null && state.userCache != null)
                {
                        if (!state.userCache.TryGetValue(_user.Id, out cache))
                        {
                                cache = new UserCacheState();
                                state.userCache[_user.Id] = cache;
                        }

                        cache.userID.value = _user.Id;
                        cache.username.value = _user.Username;
                        cache.displayName.value = _user.DisplayName;
                        cache.profilePictureURL.value = _user.AvatarUrl;
                        cache.dataUpdatedAt.value = DateTime.UtcNow;
                }

                if (cache != null && state.user != null && state.user.friends != null)
                {
                        // Update friendship state
                        var friendsDict = state.user.friends.all;
                        if (!friendsDict.ContainsKey(cache.userID.value))
                                friendsDict[cache.userID.value] = new FriendshipState();

                        friendsDict[cache.userID.value].value = _friendshipState;
                }
        }

}

