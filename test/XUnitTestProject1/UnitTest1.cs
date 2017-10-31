using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void SayHello_Test()
        {
            

            var util = new WebApplication1.Utils();
            var result = util.SayHello("tb");

            Assert.Equal("Hello tb!", result);
        }
    }
}
