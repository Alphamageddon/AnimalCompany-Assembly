// Batch 2
namespace AnimalCompany;

public class UpdateProductsAction : BaseAction
{
        private IEnumerable<ApiProduct> _products; //Field offset: 0x18

        public UpdateProductsAction(IEnumerable<ApiProduct> products)
        {
                _products = products;
        }

        public virtual void Execute(AppState state)
        {
                if (state?.products?.all == null || _products == null)
                        return;

                var dict = state.products.all;
                dict.Clear();

                foreach (var product in _products)
                {
                        var ps = new ProductState();
                        ps.id.value = product.Id;
                        ps.name.value = product.Name;
                        ps.enabled.value = product.Enabled;
                        ps.formattedPrice.value = product.FormattedPrice;
                        ps.rewardSoft.value = product.RewardSoft;
                        ps.rewardHard.value = product.RewardHard;
                        // Reward items may be null
                        if (product.RewardAvatarItems != null)
                                ps.rewardAvatarItems.FromApiModel(product.RewardAvatarItems);

                        dict[ps.id.value] = ps;
                }
        }

}

