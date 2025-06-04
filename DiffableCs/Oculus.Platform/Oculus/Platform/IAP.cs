namespace Oculus.Platform;

public static class IAP
{

	public static Request ConsumePurchase(string sku) { }

	public static Request<ProductList> GetNextProductListPage(ProductList list) { }

	public static Request<PurchaseList> GetNextPurchaseListPage(PurchaseList list) { }

	public static Request<ProductList> GetProductsBySKU(String[] skus) { }

	public static Request<PurchaseList> GetViewerPurchases() { }

	public static Request<PurchaseList> GetViewerPurchasesDurableCache() { }

	public static Request<Purchase> LaunchCheckoutFlow(string sku) { }

}

