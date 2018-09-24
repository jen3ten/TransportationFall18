using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Tests
{
    [TestFixture]
    class TruckTest
    {
        [Test]
        public void Should_Derive_Truck__Class_From_TransportType_Class()
        {
            Truck sut = new Truck();
            sut.Make = "Ford";
            string response = sut.Make;
            Assert.That(response, Is.EqualTo("Ford"));
        }
    }
}
