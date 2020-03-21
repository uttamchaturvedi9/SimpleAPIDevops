using System;
using Xunit;
using SimpleAPI.Controllers;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]

        private void GetReturnMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Uttam Chaturvedi", returnValue.Value);

        }


        [Fact]
        public void Test1()
        {

        }
    }
}
