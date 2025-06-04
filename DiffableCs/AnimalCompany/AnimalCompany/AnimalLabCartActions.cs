namespace AnimalCompany;

public static class AnimalLabCartActions
{
	internal class CopyDraftSnapshotToLocalAvatarAction : BaseAction
	{
		private UserAvatarState _draftAvatar; //Field offset: 0x18

		public CopyDraftSnapshotToLocalAvatarAction(UserAvatarState draftAvatar) { }

		public virtual void Execute(AppState state) { }

	}

	internal class UpdateUserInventoryAction : BaseAction
	{
		private String[] _ownedItems; //Field offset: 0x18

		public UpdateUserInventoryAction(String[] ownedItems) { }

		public virtual void Execute(AppState state) { }

	}

	internal class UpdateUserWalletAction : BaseAction
	{
		private int _softCurrency; //Field offset: 0x14
		private int _hardCurrency; //Field offset: 0x18

		public UpdateUserWalletAction(int softCurrency, int hardCurrency) { }

		public virtual void Execute(AppState state) { }

	}


}

