using System;

namespace ZbW.DesignPatterns.Mediator
{
    public class PoSSystem : BaseComponent
    {
        public void Buy(int customerId, decimal amount)
        {
            Console.WriteLine($"Notify Customer Payment. customerId {customerId}, amount {amount}");

            _mediator.NotifyCustomerPayment(customerId, amount, this);
        }

        public void NotifyCustomerDiscount(Customer customer, decimal discount)
        {
            Console.WriteLine($"Subtract Customer discount {customer} discount of {discount}");
        }
    }
}
