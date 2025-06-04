namespace AnimalCompany;

public static class AvatarItemUtil
{

	public static HashSet<AvatarItemState> GetItemsToPurchaseForDraftAvatar() { }

	public static bool IsItemOwned(string itemID) { }

	public static bool IsItemUnownedProduct(string itemID) { }

	public static bool TryGetParentItem(AvatarItemState item, out AvatarItemState parentItem) { }

	public static bool ValidateCart(HashSet<AvatarItemState> cartItems) { }

}

