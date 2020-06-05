using NUnit.Framework;

namespace Tests
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
            Assert.Pass();
        }

        [Test]
        public void ShouldReturnTeatcherCourse()
        {
            var teatcher = Mock.TeatcherMock();

            Assert.Greater(teatcher.Courses.Count, 0);
        }
    }
}