using InterfacExample;
using System;
using Xunit;
using Moq;

namespace InterfaceExample.Tests
{
    public class DeskFanTests
    {
        [Fact]
        public void PowerLowerThanZero_OK()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 0);
            var fan = new DeskFan(mock.Object);
            var expectrd = "Won't work.";
            var actual = fan.Work();
            Assert.Equal(expectrd, actual);

        }

        [Fact]
        public void PowerHigherThan200_Warning()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 220);
            var fan2 = new DeskFan(mock.Object);
            var expectrd2 = "Warning";
            var actual2 = fan2.Work();
            Assert.Equal(expectrd2, actual2);
        }

    }

    //class PowerSupplyLowerThanZero : IPowerSupply
    //{
    //    public int GetPower()
    //    {
    //        return 0;
    //    }
    //}

    //class PowerSupplyHigherThan200 : IPowerSupply
    //{
    //    public int GetPower()
    //    {
    //        return 210;
    //    }
    //}

}
