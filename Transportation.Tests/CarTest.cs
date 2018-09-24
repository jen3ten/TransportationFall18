using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Tests
{
    [TestFixture]
    class CarTest
    {
        [Test]
        public void Should_Derive_Car_Class_From_TransportType_Class()
        {
            Car sut = new Car();
            sut.Make = "Ford";
            string response = sut.Make;
            Assert.That(response, Is.EqualTo("Ford"));
        }

    }
}
