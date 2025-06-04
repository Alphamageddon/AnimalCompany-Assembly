namespace AnimalCompany;

public class UpdateProductsAction : BaseAction
{
	private IEnumerable<ApiProduct> _products; //Field offset: 0x18

	public UpdateProductsAction(IEnumerable<ApiProduct> products) { }

	public virtual void Execute(AppState state) { }

}

