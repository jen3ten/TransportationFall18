using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Tests
{
    [TestFixture]
    class MotorcycleTests
    {
        [Test]
        public void Should_Derive_Motorcycle_Class_From_TransportType_Class()
        {
            Motorcycle sut = new Motorcycle();
            sut.Make = "BMW";
            string response = sut.Make;
            Assert.That(response, Is.EqualTo("BMW"));
        }

        [Test]
        public void Should_Get_Cycle_TreadWear()
        {
            Motorcycle sut = new Motorcycle();
            string response = sut.GetTreadWear(20, 85, 32);
            Assert.That(response, Is.EqualTo("Unsafe"));
        }

    }
}
