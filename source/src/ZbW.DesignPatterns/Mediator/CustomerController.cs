using System;

namespace ZbW.DesignPatterns.Mediator
{
    public class CustomerController : BaseComponent
    {
        public void BookCustomerPayment(int customerId, decimal amount)
        {
            Console.WriteLine($"Book transaction. Amount {amount}");

            var customer = GetCustomer(customerId, amount);

            if (customer.Points > 1000)
            {
                _mediator.NotifyCustomerDiscount(customer, 50, this);
            }
        }

        private Customer GetCustomer(int customerId, decimal amount)
        {
            var random = new Random();
            return new Customer() { CustomerId = customerId, LastName = "Hans", Name = "Hans", Points = (int)Math.Floor(amount) };
        }
    }
}
