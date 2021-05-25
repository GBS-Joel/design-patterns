namespace ZbW.DesignPatterns.Mediator
{
    public interface IMediator
    {
        void NotifyCustomerPayment(int customerId, decimal amount, BaseComponent sender);

        void NotifyCustomerDiscount(Customer customer, decimal discount, BaseComponent sender);
    }
}
