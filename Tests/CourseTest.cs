using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class CourseTest
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
        public void ShouldReturnCourseTeatchers()
        {
            var course = Mock.CourseMock();

            Assert.Greater(course.Teatchers.Count, 0);
        }
    }
}
