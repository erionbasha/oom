using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]
    public class Tests
    {
        Vehicle v1 = new Vehicle("VW Polo", "Red", "Vehicle", 90, 12000, 2.4, 1.2);
        Sport s1 = new Sport(300);
        
        // 1. Dammy Test.
        [Test]
        public void SimpleTest()
        {
            Assert.IsTrue(1 == 1);
        }

        [Test]
        public void VehicleNameTest()
        {
            Assert.IsTrue(string.Equals(v1.Name, "VW Polo") == true);
        }

        [Test]
        public void VehiclePreisTest_1()
        {
            v1.Price = 30;
            Assert.IsTrue(v1.Price > 0);
        }

        [Test]
        public void CannotCreateVehicleWithEmptyName_1()
        {
            Assert.IsNaN(v1.MotorPover);
        }

        [Test]
        public void SportVehicle_NameIsEmpty()
        {
            var s1 = new Sport(400);
            s1.Name = null;
            Assert.IsNull(s1.Name);
        }

        [Test]
        public void CannotCreateSportVehicleWithoutPower()
        {
            var x = new Sport(-30);
            Assert.LessOrEqual(x.MotorPover, 300);
        }

        [Test]
        public void SportMorePowerThenVehicle()
        {
            Assert.Greater(s1.MotorPover, v1.MotorPover);
        }

        [Test]
        public void VechicleCostNull()
        {
            Assert.Equals(v1.Price, 0);
        }
    }
}
