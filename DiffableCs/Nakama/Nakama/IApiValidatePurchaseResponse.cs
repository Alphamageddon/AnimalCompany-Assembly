namespace Nakama;

public interface IApiValidatePurchaseResponse
{

	public IEnumerable<IApiValidatedPurchase> ValidatedPurchases
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiValidatedPurchase> get_ValidatedPurchases() { }

}

