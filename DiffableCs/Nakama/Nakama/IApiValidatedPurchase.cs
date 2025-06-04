namespace Nakama;

public interface IApiValidatedPurchase
{

	public string CreateTime
	{
		 get { } //Length: 0
	}

	public ApiStoreEnvironment Environment
	{
		 get { } //Length: 0
	}

	public string ProductId
	{
		 get { } //Length: 0
	}

	public string ProviderResponse
	{
		 get { } //Length: 0
	}

	public string PurchaseTime
	{
		 get { } //Length: 0
	}

	public string RefundTime
	{
		 get { } //Length: 0
	}

	public bool SeenBefore
	{
		 get { } //Length: 0
	}

	public ApiStoreProvider Store
	{
		 get { } //Length: 0
	}

	public string TransactionId
	{
		 get { } //Length: 0
	}

	public string UpdateTime
	{
		 get { } //Length: 0
	}

	public string UserId
	{
		 get { } //Length: 0
	}

	public string get_CreateTime() { }

	public ApiStoreEnvironment get_Environment() { }

	public string get_ProductId() { }

	public string get_ProviderResponse() { }

	public string get_PurchaseTime() { }

	public string get_RefundTime() { }

	public bool get_SeenBefore() { }

	public ApiStoreProvider get_Store() { }

	public string get_TransactionId() { }

	public string get_UpdateTime() { }

	public string get_UserId() { }

}

