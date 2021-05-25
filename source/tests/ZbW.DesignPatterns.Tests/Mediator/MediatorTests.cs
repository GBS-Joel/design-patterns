using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZbW.DesignPatterns.Mediator;

namespace ZbW.DesignPatterns.Tests.Mediator
{
    public class MediatorTests
    {
        [Fact]
        public void GetSalaryObjectAdapter_WhenEmployeeAndPresident_ThenAllSalariesListed()
        {
            var posSystem = new PoSSystem();
            var customerController = new CustomerController();

            var mediator = new ConcreteMediator(posSystem, customerController);

            posSystem.Buy(1, 1001);
        }
    }
}
