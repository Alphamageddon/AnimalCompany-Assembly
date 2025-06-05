using UnityEngine;

namespace AnimalCompany
{
    public class SetUserSoftCurrencyAmountAction : BaseAction
    {
        private int _amount;

        public SetUserSoftCurrencyAmountAction(int amount)
        {
            _amount = amount;
        }

        public override void Execute(AppState state)
        {
            if (state?.UserData?.Economy?.SoftCurrency != null)
            {
                state.UserData.Economy.SoftCurrency.Value = _amount;
            }
        }
    }
}