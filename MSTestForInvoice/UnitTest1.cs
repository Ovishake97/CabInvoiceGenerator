using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace MSTestForInvoice
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerator invoice = null;
        [TestInitialize]
        public void SetUp()
        {
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
        [TestMethod]
        public void GivenMultipleRidesReturnsTotalFares()
        {
            Ride[] rides = { new Ride(2.0, 30), new Ride(1.0, 40) };
            InvoiceSummary actual = invoice.CalculateFare(rides);
            InvoiceSummary expected = new InvoiceSummary(2, 50.0);
            Assert.AreEqual(expected, actual);
        }
    }
}
