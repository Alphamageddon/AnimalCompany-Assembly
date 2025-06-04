namespace Nakama;

public interface IApiValidatedSubscription
{

	public bool Active
	{
		 get { } //Length: 0
	}

	public string CreateTime
	{
		 get { } //Length: 0
	}

	public ApiStoreEnvironment Environment
	{
		 get { } //Length: 0
	}

	public string ExpiryTime
	{
		 get { } //Length: 0
	}

	public string OriginalTransactionId
	{
		 get { } //Length: 0
	}

	public string ProductId
	{
		 get { } //Length: 0
	}

	public string ProviderNotification
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

	public ApiStoreProvider Store
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

	public bool get_Active() { }

	public string get_CreateTime() { }

	public ApiStoreEnvironment get_Environment() { }

	public string get_ExpiryTime() { }

	public string get_OriginalTransactionId() { }

	public string get_ProductId() { }

	public string get_ProviderNotification() { }

	public string get_ProviderResponse() { }

	public string get_PurchaseTime() { }

	public string get_RefundTime() { }

	public ApiStoreProvider get_Store() { }

	public string get_UpdateTime() { }

	public string get_UserId() { }

}

