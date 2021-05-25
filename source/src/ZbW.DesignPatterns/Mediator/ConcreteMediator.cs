namespace ZbW.DesignPatterns.Mediator
{
    public class ConcreteMediator : IMediator
    {
        private readonly PoSSystem _posSystem;

        private readonly CustomerController _accountController;

        public ConcreteMediator(PoSSystem posSystem, CustomerController accountController)
        {
            _posSystem = posSystem;
            _posSystem.SetMediator(this);

            _accountController = accountController;
            _accountController.SetMediator(this);
        }

        public void NotifyCustomerDiscount(Customer customer, decimal discount, BaseComponent sender)
        {
            if (sender == _accountController)
            {
                _posSystem.NotifyCustomerDiscount(customer, discount);
            }
        }

        public void NotifyCustomerPayment(int customerId, decimal amount, BaseComponent sender)
        {
            if (sender == _posSystem)
            {
                _accountController.BookCustomerPayment(customerId, amount);
            }
        }
    }
}
