using WebSample.Controllers;
using Xunit;

namespace Teste
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("value", returnValue.Value);
        }



        [Fact]
        public void Test1()
        {

        }
    }
}
