using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Tests
{
    [TestFixture]
    class TransportationTests
    {
        [Test] 
        public void Should_Get_Make()
        {
            //Arrange
            TransportType sut = new TransportType();
            //Action
            sut.Make = "Ford";
            string response = sut.Make;
            //Assert
            Assert.That(response, Is.EqualTo("Ford"));
        }

        [Test]
        public void Should_Get_Model()
        {
            TransportType sut = new TransportType();
            sut.Model = "Bronco";
            string response = sut.Model;
            Assert.That(response, Is.EqualTo("Bronco"));
        }

        [Test]
        public void Should_Get_Year()
        {
            TransportType sut = new TransportType();
            sut.Year = "1990";
            string response = sut.Year;
            Assert.That(response, Is.EqualTo("1990"));
        }

        [Test]
        public void Should_Get_NumWheels()
        {
            TransportType sut = new TransportType();
            sut.NumWheels = 4;
            int response = sut.NumWheels;
            Assert.That(response, Is.EqualTo(4));
        }

        [Test]
        public void Should_Get_Color()
        {
            TransportType sut = new TransportType();
            sut.Color = "Blue";
            string response = sut.Color;
            Assert.That(response, Is.EqualTo("Blue"));
        }

        [Test]
        public void Should_Get_EngineSize()
        {
            TransportType sut = new TransportType();
            sut.EngineSize = "150";
            string response = sut.EngineSize;
            Assert.That(response, Is.EqualTo("150"));
        }

        [Test]
        public void Should_Get_Mph()
        {
            TransportType sut = new TransportType();
            int response = sut.GetMph(55);
            Assert.That(response, Is.EqualTo(55));
        }

        [Test]
        public void Should_Get_Mpg()
        {
            TransportType sut = new TransportType();
            int response = sut.GetMpg(55, 11);
            Assert.That(response, Is.EqualTo(605));
        }

        [Test]
        public void Should_Get_TreadWear()
        {
            TransportType sut = new TransportType();
            string response = sut.GetTreadWear(0, 0, 0);
            Assert.That(response, Is.EqualTo("Invalid Entry"));
        }

        [Test]
        public void Should_Return_Unsafe_If_Miles_Div_Temp_Less_Than_50_Perc_Of_Tread()
        {
            TransportType sut = new TransportType();
            string response = sut.GetTreadWear(20, 85, 32);
            Assert.That(response, Is.EqualTo("Unsafe"));
        }

        [Test]
        public void Should_Return_Safe_If_Miles_Div_Temp_Greater_Than_50_Perc_Of_Tread()
        {
            TransportType sut = new TransportType();
            string response = sut.GetTreadWear(1500, 85, 32);
            Assert.That(response, Is.EqualTo("Safe"));
        }

    }
}
