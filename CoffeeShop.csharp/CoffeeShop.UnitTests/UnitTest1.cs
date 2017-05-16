using Com.ManchesterDigital.CoffeeShop.Interfaces;
using Moq;
using NUnit.Framework;

namespace CoffeeShop.UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test1()
        {
            var myCoffeeShop = new Com.ManchesterDigital.CoffeeShop.CoffeeShop();
            Assert.IsNotNull(myCoffeeShop);
            var x = new Mock<IAskCustomer>();

            var y = x.Object;
        }
    }
}
