using Xunit;

namespace Not_Dot_Test
{
    public class Test1
    {


        [Fact, Trait("Category", "A")]
        public void PassTest()
        {
            var passbool = true;

            Assert.True(passbool);


        }

        [Fact, Trait("Category", "B")]
        public void FailTest()
        {
            var failbool = true;

            Assert.True(failbool);
        }

    }
}
