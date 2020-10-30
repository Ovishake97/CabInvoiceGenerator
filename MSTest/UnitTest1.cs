using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerator invoice = null;
        [TestInitialize]
        public void SetUp() {
            invoice = new InvoiceGenerator(RideType.NORMAL);
        }
        [TestMethod]
        public void GivenDistanceAndTimeReturnsFare()
        {
            double distance = 2.0;
            int time = 30;
            double fareActual = invoice.CalculateFare(distance, time);
            double fareExpected = 50;
            Assert.AreEqual(fareExpected, fareActual);
        }
    }
}
