using Xunit;

namespace Not_Dot_Test
{
    public class Test1
    {


        [Fact]
        public void PassTest()
        {
            var passbool = true;

            Assert.True(passbool);


        }

        [Fact]
        public void FailTest()
        {
            var failbool = false;

            Assert.True(failbool);
        }

    }
}
