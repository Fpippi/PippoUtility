using PippoHelperException;
using Shouldly;

namespace TesterPippoUtility
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string? testNull = null;
            ExceptionPippo.MustBeNull(testNull, nameof(testNull));


        }
    }
}