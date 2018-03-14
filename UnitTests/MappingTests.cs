using AutoMapper;
using BusinessLayer.Mapping;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class MappingTests
    {
        [Test]
        public void Test()
        {
            var config = MapperConfig.InitializeAutoMapper();

            config.AssertConfigurationIsValid();
        }
    }
}
