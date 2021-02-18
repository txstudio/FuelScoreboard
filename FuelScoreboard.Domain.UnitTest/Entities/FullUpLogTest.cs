using FluentAssertions;
using FuelScoreboard.Domain.Entities;
using NUnit.Framework;

namespace FuelScoreboard.Domain.UnitTest.Entities
{
    public sealed class FullUpLogTest
    {
        [Test]
        public void KmPerLiterShouldReturnNullWhenMeterIsNull()
        {
            var _fillUpLog = new FillUpLog();

            _fillUpLog.Meter = null;

            _fillUpLog.KmPerLiter.Should().BeNull();
        }

        [Test]
        public void KmPerLiterShouldReturnNullWhenLiterIsNull()
        {
            var _fillUpLog = new FillUpLog();

            _fillUpLog.Meter = 600;
            _fillUpLog.Liter = null;

            _fillUpLog.KmPerLiter.Should().BeNull();
        }

        [Test]
        public void KmPerLiterShoudReturnCorrectValueWhenMeterAndLiterHasValue()
        {
            var _fillUpLog = new FillUpLog();

            _fillUpLog.Meter = 487M;
            _fillUpLog.Liter = 34.7M;

            var _kmPerLiterValue = 14.03M;

            _fillUpLog.KmPerLiter.Should().Be(_kmPerLiterValue);
        }
    }
}